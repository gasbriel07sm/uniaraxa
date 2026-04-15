using System;

class BEE1158
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Trim().Split(' ');
            int a = int.Parse(p[0]);
            int b = int.Parse(p[1]);
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);
            long soma = 0;
            // Primeiro ímpar no intervalo [min, max]
            int inicio = (min % 2 != 0) ? min : min + 1;
            for (int j = inicio; j <= max; j += 2)
                soma += j;
            Console.WriteLine(soma);
        }
    }
}