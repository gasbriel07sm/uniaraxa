using System;
using System.Globalization;

class Ex06
{
    static void Main()
    {
        double[] salarios = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Salário do funcionário " + (i + 1) + ": R$ ");
            salarios[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }

        Console.WriteLine("\n=== Salários após reajuste de 5% ===");
        for (int i = 0; i < 10; i++)
        {
            salarios[i] *= 1.05;
            Console.WriteLine("Funcionário " + (i + 1) + ": R$ "
                + salarios[i].ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}