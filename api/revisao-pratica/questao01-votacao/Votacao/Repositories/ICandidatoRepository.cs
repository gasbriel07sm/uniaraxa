using Votacao.Models;

namespace Votacao.Repositories;

public interface ICandidatoRepository
{
    void Adicionar(Candidato candidato);
    IEnumerable<Candidato> BuscarTodos();
    Candidato? BuscarPorNumero(int numero);
    bool ExisteNumero(int numero);
}
