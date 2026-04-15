using System;

class Ex04
{
    static void Main()
    {
        int[,] m = new int[5, 5];

        // Preenche de 1 a 25
        int num = 1;
        for (int i = 0; i < 5; i++)
            for (int j = 0; j < 5; j++)
                m[i, j] = num++;

        // Exibe a matriz completa
        Console.WriteLine("=== Matriz 5x5 ===");
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
                Console.Write("{0,4}", m[i, j]);
            Console.WriteLine();
        }

        // Diagonal principal: i == j
        Console.WriteLine("\n=== Diagonal Principal (i == j) ===");
        for (int i = 0; i < 5; i++)
            Console.Write(m[i, i] + " ");
        Console.WriteLine();

        // Diagonal secundária: i + j == 4
        Console.WriteLine("\n=== Diagonal Secundária (i + j == 4) ===");
        for (int i = 0; i < 5; i++)
            Console.Write(m[i, 4 - i] + " ");
        Console.WriteLine();
    }
}