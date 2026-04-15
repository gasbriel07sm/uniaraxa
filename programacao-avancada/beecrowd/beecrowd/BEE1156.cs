using System;
using System.Globalization;

class BEE1156
{
    static void Main()
    {
        double s = 0, den = 1;
        for (int num = 1; num <= 39; num += 2)
        {
            s += (double)num / den;
            den *= 2;
        }
        Console.WriteLine(s.ToString("F2", CultureInfo.InvariantCulture));
    }
}