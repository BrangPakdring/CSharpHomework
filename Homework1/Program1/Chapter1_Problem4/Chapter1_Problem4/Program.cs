using System;

namespace Chapter1_Problem4
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("input number 1: ");
			var a = Convert.ToDouble(Console.ReadLine());
			Console.Write("input number 2: ");
			var b = double.Parse(Console.ReadLine());
			Console.WriteLine("result: " + a * b);
		}
	}
}
