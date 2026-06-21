List<Aluno> alunos = new List<Aluno>();

int opcao;

do
{

    Console.WriteLine();
    Console.WriteLine("===== MENU DE ALUNOS =====");
    Console.WriteLine("1 - Cadastrar aluno");
    Console.WriteLine("2 - Listar alunos");
    Console.WriteLine("3 - Alterar aluno (pelo RA)");
    Console.WriteLine("4 - Remover aluno (pelo RA)");
    Console.WriteLine("5 - Encerrar o programa");
    Console.Write("Escolha uma opção: ");

    int.TryParse(Console.ReadLine(), out opcao);

    switch (opcao)
    {
        case 1: CadastrarAluno(); break;
        case 2: ListarAlunos();   break;
        case 3: AlterarAluno();   break;
        case 4: RemoverAluno();   break;
        case 5: Console.WriteLine("Encerrando..."); break;
        default: Console.WriteLine("Opção inválida!"); break;
    }

} while (opcao != 5);

void CadastrarAluno()
{
    Console.Write("RA: ");
    string ra = Console.ReadLine();

    if (BuscarPorRA(ra) != null)
    {
        Console.WriteLine("Já existe um aluno com esse RA!");
        return;
    }

    Aluno aluno = new Aluno();
    aluno.RA = ra;

    Console.Write("Nome: ");
    aluno.Nome = Console.ReadLine();

    Console.Write("Idade: ");
    aluno.Idade = int.Parse(Console.ReadLine());

    alunos.Add(aluno);
    Console.WriteLine("Aluno cadastrado com sucesso!");
}

void ListarAlunos()
{
    if (alunos.Count == 0)
    {
        Console.WriteLine("Nenhum aluno cadastrado.");
        return;
    }

    Console.WriteLine("--- Alunos cadastrados ---");

    foreach (Aluno a in alunos)
    {
        a.MostrarDados();
    }
}

void AlterarAluno()
{
    Console.Write("Digite o RA do aluno a alterar: ");
    string ra = Console.ReadLine();

    Aluno aluno = BuscarPorRA(ra);
    if (aluno == null)
    {
        Console.WriteLine("Aluno não encontrado.");
        return;
    }

    Console.Write("Novo nome: ");
    aluno.Nome = Console.ReadLine();

    Console.Write("Nova idade: ");
    aluno.Idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Dados alterados com sucesso!");
}

void RemoverAluno()
{
    Console.Write("Digite o RA do aluno a remover: ");
    string ra = Console.ReadLine();

    Aluno aluno = BuscarPorRA(ra);
    if (aluno == null)
    {
        Console.WriteLine("Aluno não encontrado.");
        return;
    }

    alunos.Remove(aluno);
    Console.WriteLine("Aluno removido com sucesso!");
}

Aluno BuscarPorRA(string ra)
{
    foreach (Aluno a in alunos)
    {
        if (a.RA == ra)
        {
            return a;
        }
    }
    return null;
}

class Aluno
{
    public string RA { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void MostrarDados()
    {
        Console.WriteLine($"RA: {RA} | Nome: {Nome} | Idade: {Idade}");
    }
}
