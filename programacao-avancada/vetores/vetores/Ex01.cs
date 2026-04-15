using System;

class Ex01
{
    static void Main()
    {
        int[] vetor = new int[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Digite o valor para a posição " + (i + 1) + ": ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int soma = 0;
        for (int i = 0; i < 10; i++)
            soma += vetor[i];

        Console.WriteLine("Somatório: " + soma);
    }
}