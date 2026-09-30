using FeiraProjetos.Models;

namespace FeiraProjetos.Repositories;

public class VisitaRepository : IVisitaRepository
{
    private readonly List<Visita> _visitas = new();

    public void Registrar(Visita visita)
    {
        _visitas.Add(visita);
    }

    public IEnumerable<Visita> BuscarPorProjeto(int numeroProjeto)
    {
        return _visitas.Where(v => v.NumeroProjeto == numeroProjeto).ToList();
    }
}
