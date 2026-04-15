using System;

class BEE1143
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
            Console.WriteLine(i + " " + (i * i) + " " + ((long)i * i * i));
    }
}