using System;

class BEE1150
{
    static void Main()
    {
        // Lê X (não usado neste modelo) e Z
        long z = long.Parse(Console.ReadLine());
        long soma = 0, count = 0;
        for (long i = 1; soma <= z; i++)
        {
            soma += i;
            count++;
        }
        Console.WriteLine(count);
    }
}