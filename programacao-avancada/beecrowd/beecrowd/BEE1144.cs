using System;

class BEE1144
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            long q = (long)i * i;
            long c = (long)i * i * i;
            Console.WriteLine(i + " " + q + " " + c);
            Console.WriteLine(i + " " + (q + 1) + " " + (c + 1));
        }
    }
}