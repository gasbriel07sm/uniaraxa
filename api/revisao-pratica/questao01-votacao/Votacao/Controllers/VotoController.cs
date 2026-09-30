using Microsoft.AspNetCore.Mvc;
using Votacao.Models;
using Votacao.Repositories;

namespace Votacao.Controllers;

[ApiController]
[Route("api/[controller]")]
public class VotoController : ControllerBase
{
    private readonly IVotoRepository _votoRepository;
    private readonly ICandidatoRepository _candidatoRepository;

    public VotoController(IVotoRepository votoRepository, ICandidatoRepository candidatoRepository)
    {
        _votoRepository = votoRepository;
        _candidatoRepository = candidatoRepository;
    }

    // 3. Registrar voto
    [HttpPost]
    [ProducesResponseType(typeof(Voto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Registrar([FromBody] Voto voto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var numeroCandidato = voto.NumeroCandidato!.Value;

        if (!_candidatoRepository.ExisteNumero(numeroCandidato))
            return NotFound(new { mensagem = $"Nenhum candidato encontrado com o número {numeroCandidato}." });

        // Cada aluno pode votar apenas uma vez na eleição.
        if (_votoRepository.AlunoJaVotou(voto.RaAluno))
            return Conflict(new { mensagem = $"O aluno de RA {voto.RaAluno} já registrou seu voto." });

        voto.DataVoto = DateTime.Now;
        _votoRepository.Registrar(voto);

        return CreatedAtAction(nameof(BuscarPorCandidato), new { numeroCandidato }, voto);
    }

    // 4. Consultar votos por candidato
    [HttpGet("candidato/{numeroCandidato:int}")]
    [ProducesResponseType(typeof(IEnumerable<Voto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorCandidato(int numeroCandidato)
    {
        if (!_candidatoRepository.ExisteNumero(numeroCandidato))
            return NotFound(new { mensagem = $"Nenhum candidato encontrado com o número {numeroCandidato}." });

        return Ok(_votoRepository.BuscarPorCandidato(numeroCandidato));
    }
}
