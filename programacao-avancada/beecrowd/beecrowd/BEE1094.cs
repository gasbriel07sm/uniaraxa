using System;
using System.Globalization;

class BEE1094
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int total = 0, coelhos = 0, ratos = 0, sapos = 0;
        for (int i = 0; i < n; i++)
        {
            string[] p = Console.ReadLine().Trim().Split(' ');
            int qtd = int.Parse(p[0]);
            char tipo = p[1][0];
            total += qtd;
            if (tipo == 'C') coelhos += qtd;
            else if (tipo == 'R') ratos += qtd;
            else sapos += qtd;
        }
        Console.WriteLine("Total: " + total + " cobaias");
        Console.WriteLine("Total de coelhos: " + coelhos);
        Console.WriteLine("Total de ratos: " + ratos);
        Console.WriteLine("Total de sapos: " + sapos);
        Console.WriteLine("Percentual de coelhos: "
            + ((double)coelhos / total * 100).ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de ratos: "
            + ((double)ratos / total * 100).ToString("F2", CultureInfo.InvariantCulture) + " %");
        Console.WriteLine("Percentual de sapos: "
            + ((double)sapos / total * 100).ToString("F2", CultureInfo.InvariantCulture) + " %");
    }
}