using Votacao.Models;

namespace Votacao.Repositories;

public class CandidatoRepository : ICandidatoRepository
{
    private readonly List<Candidato> _candidatos = new();

    public void Adicionar(Candidato candidato)
    {
        _candidatos.Add(candidato);
    }

    public IEnumerable<Candidato> BuscarTodos()
    {
        return _candidatos;
    }

    public Candidato? BuscarPorNumero(int numero)
    {
        return _candidatos.FirstOrDefault(c => c.Numero == numero);
    }

    public bool ExisteNumero(int numero)
    {
        return _candidatos.Any(c => c.Numero == numero);
    }
}
