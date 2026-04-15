using System;
using System.Text;

class BEE1101
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            var sb = new StringBuilder();
            for (int j = 1; j <= i; j++)
            {
                if (j > 1) sb.Append(' ');
                sb.Append(j);
            }
            Console.WriteLine(sb);
        }
    }
}