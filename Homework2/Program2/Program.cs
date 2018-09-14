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
				string rawArraySize = Console.ReadLine();
				if (short.TryParse(rawArraySize, out short arraySize) == false || arraySize == 0 || arraySize < -1)
				{
					Console.WriteLine("invalid input");
					continue;
				}
				else if (arraySize == -1) break;
				else
				{
					int[] array = new int[arraySize];
//					for (int i = 0; i < array.Length; i++)
//					{
//						array[i] = new Random().Next(int.MinValue, int.MaxValue);
//					}
					int arrayIndex = 0;
					char[] separator = { ' ', '\t' };

					// read until there are exactly arraySize numbers, skip invalid inputs
					while (true)
					{
						Console.WriteLine($"input {arraySize - arrayIndex} integers in range [-2^31, 2^31):");
						string[] rawArray = Console.ReadLine().Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);

						for (int i = 0; arrayIndex < array.Length && i < rawArray.Length; ++i)
						{
							if (int.TryParse(rawArray[i], out int tmp) == false)
								Console.WriteLine($"invalid input found at {i + 1} -th position");
							else
								array[arrayIndex++] = tmp;
						}
						if (arrayIndex == arraySize) break;
					};

					// compute answers
					int max = int.MinValue;
					int min = int.MaxValue;
					long sum = 0L;
					foreach (var number in array)
					{
						max = Math.Max(max, number);
						min = Math.Min(min, number);
						sum += number;
					}
					Console.WriteLine($"maximum is {max}");
					Console.WriteLine($"minimum is {min}");
					Console.WriteLine("average is {0}", (double)sum / array.Length);
					Console.WriteLine($"sum is {sum}");
				}
			}
		}
	}
}
