using Microsoft.AspNetCore.Mvc;
using Votacao.Models;
using Votacao.Repositories;

namespace Votacao.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CandidatoController : ControllerBase
{
    private readonly ICandidatoRepository _candidatoRepository;

    public CandidatoController(ICandidatoRepository candidatoRepository)
    {
        _candidatoRepository = candidatoRepository;
    }

    // 1. Cadastro de candidatos
    [HttpPost]
    [ProducesResponseType(typeof(Candidato), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Cadastrar([FromBody] Candidato candidato)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var numero = candidato.Numero!.Value;

        // Regra de negócio: não pode existir mais de um candidato com o mesmo número.
        if (_candidatoRepository.ExisteNumero(numero))
            return Conflict(new { mensagem = $"Já existe um candidato cadastrado com o número {numero}." });

        _candidatoRepository.Adicionar(candidato);

        return CreatedAtAction(nameof(BuscarPorNumero), new { numero }, candidato);
    }

    // 2. Listar candidatos
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Candidato>), StatusCodes.Status200OK)]
    public IActionResult BuscarTodos()
    {
        return Ok(_candidatoRepository.BuscarTodos());
    }

    [HttpGet("{numero:int}")]
    [ProducesResponseType(typeof(Candidato), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorNumero(int numero)
    {
        var candidato = _candidatoRepository.BuscarPorNumero(numero);
        if (candidato is null)
            return NotFound(new { mensagem = $"Nenhum candidato encontrado com o número {numero}." });

        return Ok(candidato);
    }
}
