using System;

class Ex01
{
    static void Main(string[] args)
    {
        Console.Write("Informe x1: ");
        double x1 = double.Parse(Console.ReadLine());

        Console.Write("Informe y1: ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("Informe x2: ");
        double x2 = double.Parse(Console.ReadLine());

        Console.Write("Informe y2: ");
        double y2 = double.Parse(Console.ReadLine());

        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Distância entre os pontos: {distancia:F4}");
    }
}