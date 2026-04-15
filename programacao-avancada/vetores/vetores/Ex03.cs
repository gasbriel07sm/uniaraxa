using System;

class Ex03
{
    static void Main()
    {
        int[] vetor = new int[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nDigite o número a buscar: ");
        int busca = int.Parse(Console.ReadLine());

        bool encontrou = false;
        for (int i = 0; i < 8; i++)
        {
            if (vetor[i] == busca)
            {
                Console.WriteLine("Número encontrado na posição " + (i + 1));
                encontrou = true;
            }
        }

        if (!encontrou)
            Console.WriteLine("O número não se encontra no vetor");
    }
}