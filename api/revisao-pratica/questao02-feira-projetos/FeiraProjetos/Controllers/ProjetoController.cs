using FeiraProjetos.Models;
using FeiraProjetos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FeiraProjetos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProjetoController : ControllerBase
{
    private readonly IProjetoRepository _projetoRepository;

    public ProjetoController(IProjetoRepository projetoRepository)
    {
        _projetoRepository = projetoRepository;
    }

    // 1. Cadastro de projetos
    [HttpPost]
    [ProducesResponseType(typeof(Projeto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Cadastrar([FromBody] Projeto projeto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var numero = projeto.Numero!.Value;

        // Regra de negócio: não pode existir mais de um projeto com o mesmo número.
        if (_projetoRepository.ExisteNumero(numero))
            return Conflict(new { mensagem = $"Já existe um projeto cadastrado com o número {numero}." });

        _projetoRepository.Adicionar(projeto);

        return CreatedAtAction(nameof(BuscarPorNumero), new { numero }, projeto);
    }

    // 2. Listar projetos
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Projeto>), StatusCodes.Status200OK)]
    public IActionResult BuscarTodos()
    {
        return Ok(_projetoRepository.BuscarTodos());
    }

    [HttpGet("{numero:int}")]
    [ProducesResponseType(typeof(Projeto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorNumero(int numero)
    {
        var projeto = _projetoRepository.BuscarPorNumero(numero);
        if (projeto is null)
            return NotFound(new { mensagem = $"Nenhum projeto encontrado com o número {numero}." });

        return Ok(projeto);
    }
}
