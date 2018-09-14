using System;

namespace Program1
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("input an integer in range [0, 2 ^ 31), or -1 to exit:");
				string rawNumber = Console.ReadLine();
				
				if (int.TryParse(rawNumber, out int number) == false || number < -1)
				{
					Console.WriteLine("invalid input");
					continue;
				}
				else if (number == -1) break;
				else
				{ 
					int count = 0;
					for (int i = 2, limit = (int)Math.Sqrt(number); i <= limit && i <= number; ++i)
					{
						if (number % i == 0)
						{
							++count;
							Console.Write(i + "\t");
							while (number % i == 0) number /= i;
						}
					}
					if (number > 1)
					{
						++count;
						Console.Write(number);
					}
					Console.WriteLine();
					Console.WriteLine(count + " numbers in total");
				}
			}
		}
	}
}
