using System;

class Ex03
{
    static void Main()
    {
        Console.Write("Digite A: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Digite B: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Digite C: ");
        int c = int.Parse(Console.ReadLine());

        double r = Math.Pow(a + b, 2);
        double s = Math.Pow(b + c, 2);
        double d = (r + s) / 2;

        Console.WriteLine($"O resultado de D é: {d}");
    }
}