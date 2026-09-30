using FeiraProjetos.Models;

namespace FeiraProjetos.Repositories;

public class ProjetoRepository : IProjetoRepository
{
    private readonly List<Projeto> _projetos = new();

    public void Adicionar(Projeto projeto)
    {
        _projetos.Add(projeto);
    }

    public IEnumerable<Projeto> BuscarTodos()
    {
        return _projetos;
    }

    public Projeto? BuscarPorNumero(int numero)
    {
        return _projetos.FirstOrDefault(p => p.Numero == numero);
    }

    public bool ExisteNumero(int numero)
    {
        return _projetos.Any(p => p.Numero == numero);
    }
}
