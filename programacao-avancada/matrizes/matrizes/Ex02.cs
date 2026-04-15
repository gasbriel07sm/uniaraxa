using System;
using System.Globalization;

class Ex02
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] precos = new double[10];

        // Cadastro
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Nome do produto " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();
            Console.Write("Preço: R$ ");
            precos[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        // Filtro
        Console.Write("\nDigite o valor máximo para pesquisa: R$ ");
        double limite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("\n=== Produtos com preço até R$ "
            + limite.ToString("F2", CultureInfo.InvariantCulture) + " ===");

        bool achou = false;
        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= limite)
            {
                Console.WriteLine(nomes[i] + " - R$ "
                    + precos[i].ToString("F2", CultureInfo.InvariantCulture));
                achou = true;
            }
        }
        if (!achou)
            Console.WriteLine("Nenhum produto encontrado nessa faixa de preço.");
    }
}