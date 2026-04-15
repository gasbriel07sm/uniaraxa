using System;
using System.Globalization;

class BEE1160
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Trim().Split(' ');
            double popA = double.Parse(p[0], CultureInfo.InvariantCulture);
            double taxaA = double.Parse(p[1], CultureInfo.InvariantCulture);
            double popB = double.Parse(p[2], CultureInfo.InvariantCulture);
            double taxaB = double.Parse(p[3], CultureInfo.InvariantCulture);

            int anos = 0;
            for (; popA <= popB; anos++)
            {
                popA += popA * taxaA / 100.0;
                popB += popB * taxaB / 100.0;
            }
            Console.WriteLine(anos + (anos == 1 ? " ano" : " anos"));
        }
    }
}