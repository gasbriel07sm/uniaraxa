using System;

class Ex04
{
    static void Main(string[] args)
    {
        double S = 0.0;

        for (int i = 1; i <= 100; i++)
        {
            S += 1.0 / i;
        }

        Console.WriteLine($"Valor de S = {S:F4}");
    }
}