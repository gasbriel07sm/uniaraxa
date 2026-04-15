using System;

class Ex01
{
    static void Main()
    {
        int[] vetor = new int[15];

        for (int i = 0; i < 15; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n=== Valores nas posições pares ===");
        for (int i = 0; i < 15; i++)
        {
            if (i % 2 == 0)  // índice par: 0, 2, 4, 6, 8, 10, 12, 14
                Console.WriteLine("Posição " + (i + 1) + " -> " + vetor[i]);
        }
    }
}