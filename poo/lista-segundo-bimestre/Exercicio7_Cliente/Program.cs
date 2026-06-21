List<Cliente> clientes = new List<Cliente>();

int opcao;

do
{

    Console.WriteLine();
    Console.WriteLine("===== MENU DE CLIENTES =====");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Listar clientes");
    Console.WriteLine("3 - Buscar cliente por nome");
    Console.WriteLine("4 - Remover cliente");
    Console.WriteLine("5 - Sair");
    Console.Write("Escolha uma opção: ");

    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1: CadastrarCliente(); break;
        case 2: ListarClientes();   break;
        case 3: BuscarCliente();    break;
        case 4: RemoverCliente();   break;
        case 5: Console.WriteLine("Saindo..."); break;
        default: Console.WriteLine("Opção inválida!"); break;
    }

} while (opcao != 5);

void CadastrarCliente()
{
    Console.Write("Nome: ");
    string nome = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Nome não pode ser vazio!");
        return;
    }

    Cliente c = new Cliente();
    c.Nome = nome;

    Console.Write("Telefone: ");
    c.Telefone = Console.ReadLine();

    Console.Write("Cidade: ");
    c.Cidade = Console.ReadLine();

    clientes.Add(c);
    Console.WriteLine("Cliente cadastrado!");
}

void ListarClientes()
{
    if (clientes.Count == 0)
    {
        Console.WriteLine("Nenhum cliente cadastrado.");
        return;
    }

    Console.WriteLine("--- Clientes cadastrados ---");
    foreach (Cliente c in clientes)
    {
        c.MostrarDados();
    }
}

void BuscarCliente()
{
    Console.Write("Digite o nome a buscar: ");
    string nome = Console.ReadLine();

    bool encontrado = false;
    foreach (Cliente c in clientes)
    {

        if (c.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase))
        {
            c.MostrarDados();
            encontrado = true;
        }
    }

    if (!encontrado)
    {
        Console.WriteLine("Cliente não encontrado.");
    }
}

void RemoverCliente()
{
    Console.Write("Digite o nome do cliente a remover: ");
    string nome = Console.ReadLine();

    Cliente c = clientes.Find(x => x.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

    if (c == null)
    {
        Console.WriteLine("Cliente não encontrado.");
        return;
    }

    clientes.Remove(c);
    Console.WriteLine("Cliente removido!");
}

class Cliente
{
    public string Nome { get; set; }
    public string Telefone { get; set; }
    public string Cidade { get; set; }

    public void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome} | Telefone: {Telefone} | Cidade: {Cidade}");
    }
}
