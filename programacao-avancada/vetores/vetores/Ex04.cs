using System;

class Ex04
{
    static void Main()
    {
        int[] a = new int[10];
        int[] b = new int[10];
        int[] c = new int[10];

        Console.WriteLine("=== Vetor A ===");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("A[" + (i + 1) + "]: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n=== Vetor B ===");
        for (int i = 0; i < 10; i++)
        {
            Console.Write("B[" + (i + 1) + "]: ");
            b[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 10; i++)
            c[i] = a[i] + b[i];

        Console.WriteLine("\n=== Vetor Resultante (A + B) ===");
        for (int i = 0; i < 10; i++)
            Console.WriteLine("C[" + (i + 1) + "] = " + c[i]);
    }
}