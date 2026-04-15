using System;

class BEE1072
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());
		int dentro = 0, fora = 0;
		for (int i = 0; i < n; i++)
		{
			int x = int.Parse(Console.ReadLine());
			if (x >= 10 && x <= 20) dentro++;
			else fora++;
		}
		Console.WriteLine(dentro + " in");
		Console.WriteLine(fora + " out");
	}
}