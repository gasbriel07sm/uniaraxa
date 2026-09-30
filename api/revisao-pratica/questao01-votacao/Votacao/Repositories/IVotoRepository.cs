using Votacao.Models;

namespace Votacao.Repositories;

public interface IVotoRepository
{
    void Registrar(Voto voto);
    IEnumerable<Voto> BuscarPorCandidato(int numeroCandidato);
    bool AlunoJaVotou(string raAluno);
}
