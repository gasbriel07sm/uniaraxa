using System;

class BEE1142
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int num = 1;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(num + " " + (num + 1) + " " + (num + 2) + " PUM");
            num += 4;
        }
    }
}