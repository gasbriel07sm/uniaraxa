List<Produto> produtos = new List<Produto>();

for (int i = 1; i <= 4; i++)
{
    Console.WriteLine($"--- Produto {i} ---");

    Produto p = new Produto();

    Console.Write("Nome: ");
    p.Nome = Console.ReadLine();

    Console.Write("Preço: ");
    p.Preco = double.Parse(Console.ReadLine());

    produtos.Add(p);
    Console.WriteLine();
}

Console.WriteLine("Produtos cadastrados:");
double total = 0;
foreach (Produto p in produtos)
{

    Console.WriteLine($"{p.Nome} - R$ {p.Preco:F2}");
    total += p.Preco;
}

Console.WriteLine();
Console.WriteLine($"Valor total: R$ {total:F2}");

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}
