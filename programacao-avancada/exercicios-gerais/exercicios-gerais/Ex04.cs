using System;

class Ex04
{
    static void Main()
    {
        Console.Write("Nota 1: ");
        double n1 = double.Parse(Console.ReadLine());
        Console.Write("Nota 2: ");
        double n2 = double.Parse(Console.ReadLine());
        Console.Write("Nota 3: ");
        double n3 = double.Parse(Console.ReadLine());

        // Pesos: 2, 3 e 5
        double media = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / (2 + 3 + 5);

        Console.WriteLine($"A média final ponderada é: {media:F1}");
    }
}