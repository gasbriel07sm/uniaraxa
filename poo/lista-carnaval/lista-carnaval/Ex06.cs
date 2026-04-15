using System;

class Ex06
{
    static void Main(string[] args)
    {
        Console.Write("Preço atual do produto (R$): ");
        double precoAtual = double.Parse(Console.ReadLine());

        Console.Write("Venda média mensal do produto: ");
        double vendaMedia = double.Parse(Console.ReadLine());

        double novoPreco = precoAtual;

        if (vendaMedia < 500 || precoAtual < 30.0)
        {
            // Aumento de 10%
            novoPreco = precoAtual + (precoAtual * 0.10);
            Console.WriteLine("Regra aplicada: aumento de 10%.");
        }
        else if ((vendaMedia >= 500 && vendaMedia < 1200) ||
                 (precoAtual >= 30.0 && precoAtual < 80.0))
        {
            // Aumento de 15%
            novoPreco = precoAtual + (precoAtual * 0.15);
            Console.WriteLine("Regra aplicada: aumento de 15%.");
        }
        else if (vendaMedia >= 1200 || precoAtual >= 80.0)
        {
            // Diminuição de 20%
            novoPreco = precoAtual - (precoAtual * 0.20);
            Console.WriteLine("Regra aplicada: diminuição de 20%.");
        }
        else
        {
            Console.WriteLine("Produto não sofreu reajuste.");
        }

        Console.WriteLine($"Preço anterior: R$ {precoAtual:F2}");
        Console.WriteLine($"Novo preço:    R$ {novoPreco:F2}");
    }
}