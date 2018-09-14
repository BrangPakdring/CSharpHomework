using System;

namespace Program1
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("input an integer in range [2, 2 ^ 31), or -1 to exit:");
				string rawNumber = Console.ReadLine();
				
				if (int.TryParse(rawNumber, out int number) == false || number < 2 && number != -1)
				{
					Console.WriteLine("invalid input");
					continue;
				}
				else if (number == -1) break;
				else
				{ 
					Console.Write(number + "=");
					bool firstPosition = true;
					for (int i = 2, limit = (int)Math.Sqrt(number); i <= limit && i <= number; ++i)
					{
						while (number % i == 0)
						{
							number /= i;
							if (!firstPosition)Console.Write("*");
							firstPosition = false;
							Console.Write(i);
						}
					}

					if (number > 1)
					{
						if (!firstPosition)Console.Write("*");
						Console.Write(number);
					}
					Console.WriteLine();
				}
			}
		}
	}
}
