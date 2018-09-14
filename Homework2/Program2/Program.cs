using System;

namespace Program2
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("input a positive integer in range [1, 32768) the size of array, or -1 to exit:");
				var rawArraySize = Console.ReadLine();
				if (short.TryParse(rawArraySize, out short arraySize) == false || arraySize == 0 || arraySize < -1)
				{
					Console.WriteLine("invalid input");
					continue;
				}
				else
				{
					if (arraySize == -1) break;

					var array = new int[arraySize];
					int arrayIndex = 0;
					
					while (true)
					{
						Console.WriteLine($"input {arraySize - arrayIndex} integers in range [-2^31, 2^31):");
						char[] seperator = { ' ', '\t' };
						var rawArray = Console.ReadLine().Trim().Split(seperator, StringSplitOptions.RemoveEmptyEntries);

						for (var i = 0; arrayIndex < array.Length && i < rawArray.Length; ++i)
						{
							if (int.TryParse(rawArray[i], out int tmp) == false)
							{
								Console.WriteLine($"invalid input found at {i + 1} -th position");
							}
							else
							{
								array[arrayIndex++] = tmp;
							}
						}
						if (arrayIndex == arraySize) break;
					};

					var max = int.MinValue;
					var min = int.MaxValue;
					var sum = 0L;
					foreach (var number in array)
					{
						max = Math.Max(max, number);
						min = Math.Min(min, number);
						sum += number;
					}
					Console.WriteLine($"maximum value is {max}");
					Console.WriteLine($"minimum value is {min}");
					Console.WriteLine("average value is {0}", (double)sum / array.Length);
					Console.WriteLine($"sum is {sum}");
				}
			}
		}
	}
}
