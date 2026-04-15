using System;

class Ex05
{
    static void Main()
    {
        int[] vetor = new int[20];

        for (int i = 0; i < 20; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int pares = 0, impares = 0, maiores50 = 0, menores7 = 0;

        for (int i = 0; i < 20; i++)
        {
            if (vetor[i] % 2 == 0) pares++;
            else impares++;

            if (vetor[i] > 50) maiores50++;
            if (vetor[i] < 7) menores7++;
        }

        Console.WriteLine("\n=== Resultados ===");
        Console.WriteLine("Pares:           " + pares);
        Console.WriteLine("Ímpares:         " + impares);
        Console.WriteLine("Maiores que 50:  " + maiores50);
        Console.WriteLine("Menores que 7:   " + menores7);
    }
}