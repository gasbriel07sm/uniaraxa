using System;

class BEE1073
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i += 2)
            Console.WriteLine(i + "^2 = " + (i * i));
    }
}