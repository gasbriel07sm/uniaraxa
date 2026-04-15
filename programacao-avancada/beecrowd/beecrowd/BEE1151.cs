using System;

class BEE1151
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long[] fib = new long[n];
        if (n >= 1) fib[0] = 0;
        if (n >= 2) fib[1] = 1;
        for (int i = 2; i < n; i++)
            fib[i] = fib[i - 1] + fib[i - 2];
        Console.WriteLine(string.Join(" ", fib));
    }
}