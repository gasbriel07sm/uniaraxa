using System;

class Ex02
{
    static void Main()
    {
        Console.WriteLine("Ponto 1 (x1):");
        double x1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ponto 1 (y1):");
        double y1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Ponto 2 (x2):");
        double x2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Ponto 2 (y2):");
        double y2 = double.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"A distância entre os pontos é: {distancia:F2}");
    }
}