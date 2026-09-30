using FeiraProjetos.Models;

namespace FeiraProjetos.Repositories;

public interface IProjetoRepository
{
    void Adicionar(Projeto projeto);
    IEnumerable<Projeto> BuscarTodos();
    Projeto? BuscarPorNumero(int numero);
    bool ExisteNumero(int numero);
}
