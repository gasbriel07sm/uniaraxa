using System;

class Ex03
{
    static void Main(string[] args)
    {
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine());

        Console.Write("Sexo (M/F): ");
        char sexo = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        double pesoIdeal;

        if (sexo == 'M')
        {
            pesoIdeal = (72.7 * altura) - 58.0;
        }
        else if (sexo == 'F')
        {
            pesoIdeal = (62.1 * altura) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido. Use 'M' ou 'F'.");
            return;
        }

        Console.WriteLine($"Peso ideal aproximado: {pesoIdeal:F2} kg");
    }
}