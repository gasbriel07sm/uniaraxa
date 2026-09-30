using Votacao.Models;

namespace Votacao.Repositories;

public class VotoRepository : IVotoRepository
{
    private readonly List<Voto> _votos = new();

    public void Registrar(Voto voto)
    {
        _votos.Add(voto);
    }

    public IEnumerable<Voto> BuscarPorCandidato(int numeroCandidato)
    {
        return _votos.Where(v => v.NumeroCandidato == numeroCandidato).ToList();
    }

    public bool AlunoJaVotou(string raAluno)
    {
        return _votos.Any(v => v.RaAluno.Equals(raAluno, StringComparison.OrdinalIgnoreCase));
    }
}
