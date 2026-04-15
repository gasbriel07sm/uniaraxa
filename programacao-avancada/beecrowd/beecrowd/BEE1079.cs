using System;
using System.Globalization;

class BEE1079
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Trim().Split(' ');
            double a = double.Parse(p[0], CultureInfo.InvariantCulture);
            double b = double.Parse(p[1], CultureInfo.InvariantCulture);
            double c = double.Parse(p[2], CultureInfo.InvariantCulture);
            double media = (a * 2 + b * 3 + c * 5) / 10.0;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}