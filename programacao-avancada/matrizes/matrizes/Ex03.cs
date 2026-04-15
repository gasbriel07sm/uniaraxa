using System;

class Ex03
{
    static void Main()
    {
        int linhas = 3, colunas = 5;
        int[,] matriz = new int[linhas, colunas];

        // Leitura
        for (int i = 0; i < linhas; i++)
        {
            Console.WriteLine("=== Linha " + (i + 1) + " ===");
            for (int j = 0; j < colunas; j++)
            {
                Console.Write("  Coluna " + (j + 1) + ": ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Soma por linha
        Console.WriteLine("\n=== Soma de cada linha ===");
        for (int i = 0; i < linhas; i++)
        {
            int soma = 0;
            for (int j = 0; j < colunas; j++)
                soma += matriz[i, j];
            Console.WriteLine("Soma da linha " + (i + 1) + ": " + soma);
        }
    }
}