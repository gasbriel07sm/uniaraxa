using FeiraProjetos.Models;
using FeiraProjetos.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FeiraProjetos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VisitaController : ControllerBase
{
    private readonly IVisitaRepository _visitaRepository;
    private readonly IProjetoRepository _projetoRepository;

    public VisitaController(IVisitaRepository visitaRepository, IProjetoRepository projetoRepository)
    {
        _visitaRepository = visitaRepository;
        _projetoRepository = projetoRepository;
    }

    // 3. Registrar visita
    [HttpPost]
    [ProducesResponseType(typeof(Visita), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Registrar([FromBody] Visita visita)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var numeroProjeto = visita.NumeroProjeto!.Value;

        if (!_projetoRepository.ExisteNumero(numeroProjeto))
            return NotFound(new { mensagem = $"Nenhum projeto encontrado com o número {numeroProjeto}." });

        _visitaRepository.Registrar(visita);

        return CreatedAtAction(nameof(BuscarPorProjeto), new { numeroProjeto }, visita);
    }

    // 4. Consultar visitas por projeto
    [HttpGet("projeto/{numeroProjeto:int}")]
    [ProducesResponseType(typeof(IEnumerable<Visita>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorProjeto(int numeroProjeto)
    {
        if (!_projetoRepository.ExisteNumero(numeroProjeto))
            return NotFound(new { mensagem = $"Nenhum projeto encontrado com o número {numeroProjeto}." });

        return Ok(_visitaRepository.BuscarPorProjeto(numeroProjeto));
    }
}
