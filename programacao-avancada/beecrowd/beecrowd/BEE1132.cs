using System;

class BEE1132
{
    static void Main()
    {
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        int min = Math.Min(x, y);
        int max = Math.Max(x, y);
        long soma = 0;
        for (int i = min; i <= max; i++)
            if (i % 13 != 0) soma += i;
        Console.WriteLine(soma);
    }
}