using System;

class Ex07
{
    static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n=== Vetor original ===");
        for (int i = 0; i < 10; i++)
            Console.Write(vetor[i] + " ");
        Console.WriteLine();

        // Troca: primeiro ↔ último, segundo ↔ penúltimo...
        for (int i = 0; i < 10 / 2; i++)
        {
            int temp = vetor[i];
            vetor[i] = vetor[9 - i];
            vetor[9 - i] = temp;
        }

        Console.WriteLine("\n=== Vetor após as trocas ===");
        for (int i = 0; i < 10; i++)
            Console.Write(vetor[i] + " ");
        Console.WriteLine();
    }
}