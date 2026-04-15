using System;

class Ex05
{
    static void Main()
    {
        Console.Write("Digite um número inteiro: ");
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
            Console.WriteLine("O número é PAR.");
        else
            Console.WriteLine("O número é ÍMPAR.");
    }
}