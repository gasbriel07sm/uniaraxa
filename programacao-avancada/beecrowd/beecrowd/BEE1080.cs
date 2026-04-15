using System;

class BEE1080
{
    static void Main()
    {
        int maior = int.MinValue, posicao = 0;
        for (int i = 1; i <= 100; i++)
        {
            int x = int.Parse(Console.ReadLine());
            if (x > maior) { maior = x; posicao = i; }
        }
        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}