using System;
using System.Globalization;

class Ex05
{
    static void Main()
    {
        int numAlunos = 10, numNotas = 3;

        string[] nomes = new string[numAlunos];
        double[,] notas = new double[numAlunos, numNotas];
        double[] medias = new double[numAlunos];

        for (int i = 0; i < numAlunos; i++)
        {
            Console.Write("Nome do aluno " + (i + 1) + ": ");
            nomes[i] = Console.ReadLine();

            double soma = 0;
            for (int j = 0; j < numNotas; j++)
            {
                Console.Write("  Nota " + (j + 1) + ": ");
                notas[i, j] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                soma += notas[i, j];
            }
            medias[i] = soma / numNotas;
        }

        Console.WriteLine("\n========== RELATÓRIO FINAL ==========");
        for (int i = 0; i < numAlunos; i++)
        {
            bool aprovado = medias[i] >= 7.0;

            Console.ForegroundColor = aprovado ? ConsoleColor.Blue : ConsoleColor.Red;

            Console.WriteLine("\nAluno:  " + nomes[i]);
            Console.Write("Notas:  ");
            for (int j = 0; j < numNotas; j++)
                Console.Write(notas[i, j].ToString("F1", CultureInfo.InvariantCulture) + "  ");
            Console.WriteLine();
            Console.WriteLine("Média:  " + medias[i].ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("Status: " + (aprovado ? "APROVADO" : "REPROVADO"));
        }

        Console.ResetColor();
        Console.WriteLine("\n=====================================");
    }
}