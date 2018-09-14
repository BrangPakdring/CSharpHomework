using System;

namespace Program3
{
	class Program
	{
		static void Main(string[] args)
		{
			const int limit = 100;
			Console.WriteLine($"prime numbers in range [2, {limit}]:");
			var flag = new bool[limit + 1];
			for (var i = 2; i <= 100; ++i)
			{
				if (!flag[i])
				{
					for (int j = i * i; j <= limit; j += i)
						flag[j] = true;
					Console.Write(i + "\t");
				}
			}
			Console.WriteLine();
		}
	}
}
