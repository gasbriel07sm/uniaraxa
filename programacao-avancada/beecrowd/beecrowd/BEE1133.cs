using System;

class BEE1133
{
	static void Main()
	{
		int x = int.Parse(Console.ReadLine());
		int y = int.Parse(Console.ReadLine());
		int min = Math.Min(x, y);
		int max = Math.Max(x, y);
		for (int i = min + 1; i < max; i++)
		{
			int r = i % 5;
			if (r == 2 || r == 3) Console.WriteLine(i);
		}
	}
}