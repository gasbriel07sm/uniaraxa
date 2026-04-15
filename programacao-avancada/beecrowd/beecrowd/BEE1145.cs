using System;

class BEE1145
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            long q = (long)i * i;
            long c = (long)i * i * i;
            for (int k = 0; k < 3; k++)
                Console.WriteLine(i + " " + (q + k) + " " + (c + k));
        }
    }
}