using System;
using System.Text;

class BEE1149
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int start = 1; start < n; start++)
        {
            long soma = 0;
            for (int end = start; end < n; end++)
            {
                soma += end;
                if (soma == n)
                {
                    // Monta a string "N = a + a+1 + ... + end"
                    var sb = new StringBuilder();
                    sb.Append(n + " = ");
                    for (int k = start; k <= end; k++)
                    {
                        if (k > start) sb.Append(" + ");
                        sb.Append(k);
                    }
                    Console.WriteLine(sb);
                    break;
                }
                if (soma > n) break;
            }
        }
    }
}