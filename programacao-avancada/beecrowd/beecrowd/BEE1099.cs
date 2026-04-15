using System;

class BEE1099
{
    static void Main()
    {
        for (int i = 1; i <= 9; i += 2)
            for (int j = i + 6; j >= 5; j -= 2)
                Console.WriteLine("I=" + i + " J=" + j);
    }
}