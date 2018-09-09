using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
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
