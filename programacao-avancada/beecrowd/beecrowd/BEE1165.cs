using System;

class BEE1165
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 2; i <= n; i++)
        {
            bool primo = true;
            for (int j = 2; (long)j * j <= i; j++)
            {
                if (i % j == 0) { primo = false; break; }
            }
            if (primo) Console.WriteLine(i);
        }
    }
}