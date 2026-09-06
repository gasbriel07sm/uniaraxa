using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    // Como ainda não temos um banco de dados, os dados ficam armazenados
    // em memória nesta LIST<>. O "static" faz a lista ser compartilhada
    // entre todas as requisições enquanto a aplicação estiver rodando.
    private static readonly List<Pessoa> _pessoas = new();

    // a. Adicionar uma pessoa
    [HttpPost]
    [ProducesResponseType(typeof(Pessoa), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Adicionar([FromBody] Pessoa pessoa)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        // Não deixa cadastrar duas pessoas com o mesmo CPF.
        bool jaExiste = _pessoas.Any(p => p.Cpf == pessoa.Cpf);
        if (jaExiste)
            return Conflict(new { mensagem = $"Já existe uma pessoa cadastrada com o CPF {pessoa.Cpf}." });

        _pessoas.Add(pessoa);

        // Retorna 201 Created apontando para o endpoint de busca por CPF.
        return CreatedAtAction(nameof(BuscarPorCpf), new { cpf = pessoa.Cpf }, pessoa);
    }

    // b. Atualizar os dados de uma pessoa (localizada pelo CPF)
    [HttpPut("{cpf}")]
    [ProducesResponseType(typeof(Pessoa), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Atualizar(string cpf, [FromBody] Pessoa pessoa)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existente = _pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhuma pessoa encontrada com o CPF {cpf}." });

        // Atualiza os campos. O CPF continua sendo o da URL (o CPF é a "chave").
        existente.Nome = pessoa.Nome;
        existente.Peso = pessoa.Peso;
        existente.Altura = pessoa.Altura;

        return Ok(existente);
    }

    // c. Remover uma pessoa pelo CPF
    [HttpDelete("{cpf}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Remover(string cpf)
    {
        var existente = _pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhuma pessoa encontrada com o CPF {cpf}." });

        _pessoas.Remove(existente);
        return NoContent();
    }

    // d. Buscar todas as pessoas
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Pessoa>), StatusCodes.Status200OK)]
    public IActionResult BuscarTodas()
    {
        return Ok(_pessoas);
    }

    // e. Buscar uma pessoa específica informando o CPF
    [HttpGet("{cpf}")]
    [ProducesResponseType(typeof(Pessoa), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorCpf(string cpf)
    {
        var pessoa = _pessoas.FirstOrDefault(p => p.Cpf == cpf);
        if (pessoa is null)
            return NotFound(new { mensagem = $"Nenhuma pessoa encontrada com o CPF {cpf}." });

        return Ok(pessoa);
    }

    // f. Buscar todas as pessoas com IMC bom (entre 18 e 24)
    [HttpGet("imc-bom")]
    [ProducesResponseType(typeof(IEnumerable<Pessoa>), StatusCodes.Status200OK)]
    public IActionResult BuscarImcBom()
    {
        var pessoas = _pessoas
            .Where(p => p.Imc >= 18 && p.Imc <= 24)
            .ToList();

        return Ok(pessoas);
    }

    // g. Buscar pessoas por nome (contém o texto informado, sem diferenciar maiúsc./minúsc.)
    // Ex.: /api/pessoa/buscar-por-nome?nome=Humberto
    [HttpGet("buscar-por-nome")]
    [ProducesResponseType(typeof(IEnumerable<Pessoa>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult BuscarPorNome([FromQuery] string nome)
    {
        if (string.IsNullOrWhiteSpace(nome))
            return BadRequest(new { mensagem = "Informe um nome para a busca." });

        var pessoas = _pessoas
            .Where(p => p.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Ok(pessoas);
    }
}
