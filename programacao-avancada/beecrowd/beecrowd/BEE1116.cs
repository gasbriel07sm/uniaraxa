using System;
using System.Globalization;

class BEE1116
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Trim().Split(' ');
            double x = double.Parse(p[0], CultureInfo.InvariantCulture);
            double y = double.Parse(p[1], CultureInfo.InvariantCulture);
            if (y == 0)
                Console.WriteLine("divisao impossivel");
            else
                Console.WriteLine((x / y).ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}