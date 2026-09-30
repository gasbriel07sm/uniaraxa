using FeiraProjetos.Models;

namespace FeiraProjetos.Repositories;

public interface IVisitaRepository
{
    void Registrar(Visita visita);
    IEnumerable<Visita> BuscarPorProjeto(int numeroProjeto);
}
