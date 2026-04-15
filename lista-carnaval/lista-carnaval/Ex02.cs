using System;

class Ex02
{
    static void Main(string[] args)
    {
        Console.Write("Digite A: ");
        int A = int.Parse(Console.ReadLine());

        Console.Write("Digite B: ");
        int B = int.Parse(Console.ReadLine());

        Console.Write("Digite C: ");
        int C = int.Parse(Console.ReadLine());

        double R = Math.Pow(A + B, 2);
        double S = Math.Pow(B + C, 2);
        double D = (R + S) / 2.0;

        Console.WriteLine($"R = {R}");
        Console.WriteLine($"S = {S}");
        Console.WriteLine($"D = (R + S) / 2 = {D}");
    }
}