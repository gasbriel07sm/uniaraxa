using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AlunoController : ControllerBase
{
    private static readonly List<Aluno> _alunos = new();

    // a. Adicionar um aluno
    [HttpPost]
    [ProducesResponseType(typeof(Aluno), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Adicionar([FromBody] Aluno aluno)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        bool jaExiste = _alunos.Any(a => a.Ra == aluno.Ra);
        if (jaExiste)
            return Conflict(new { mensagem = $"Já existe um aluno cadastrado com o RA {aluno.Ra}." });

        _alunos.Add(aluno);

        return CreatedAtAction(nameof(BuscarPorRa), new { ra = aluno.Ra }, aluno);
    }

    // b. Atualizar os dados de um aluno (localizado pelo RA)
    [HttpPut("{ra}")]
    [ProducesResponseType(typeof(Aluno), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Atualizar(string ra, [FromBody] Aluno aluno)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existente = _alunos.FirstOrDefault(a => a.Ra == ra);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhum aluno encontrado com o RA {ra}." });

        existente.Nome = aluno.Nome;
        existente.Email = aluno.Email;
        existente.Cpf = aluno.Cpf;
        existente.Ativo = aluno.Ativo;

        return Ok(existente);
    }

    // c. Remover um aluno pelo RA
    [HttpDelete("{ra}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Remover(string ra)
    {
        var existente = _alunos.FirstOrDefault(a => a.Ra == ra);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhum aluno encontrado com o RA {ra}." });

        _alunos.Remove(existente);
        return NoContent();
    }

    // d. Buscar todos os alunos
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Aluno>), StatusCodes.Status200OK)]
    public IActionResult BuscarTodos()
    {
        return Ok(_alunos);
    }

    // e. Buscar um aluno específico informando o RA
    [HttpGet("{ra}")]
    [ProducesResponseType(typeof(Aluno), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorRa(string ra)
    {
        var aluno = _alunos.FirstOrDefault(a => a.Ra == ra);
        if (aluno is null)
            return NotFound(new { mensagem = $"Nenhum aluno encontrado com o RA {ra}." });

        return Ok(aluno);
    }

    // f. Buscar apenas os alunos ativos
    [HttpGet("ativos")]
    [ProducesResponseType(typeof(IEnumerable<Aluno>), StatusCodes.Status200OK)]
    public IActionResult BuscarAtivos()
    {
        var ativos = _alunos.Where(a => a.Ativo).ToList();
        return Ok(ativos);
    }

    // g. Buscar alunos por nome (contém o texto informado, sem diferenciar maiúsc./minúsc.)
    [HttpGet("buscar-por-nome")]
    [ProducesResponseType(typeof(IEnumerable<Aluno>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult BuscarPorNome([FromQuery] string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            return BadRequest(new { mensagem = "Informe um nome para a busca." });

        var alunos = _alunos
            .Where(a => a.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Ok(alunos);
    }
}
