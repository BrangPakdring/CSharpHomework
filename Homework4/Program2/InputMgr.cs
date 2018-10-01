using System;

namespace Program2
{
	public class InputMgr
	{
		private static string raw;

		public static bool ReadInt32(out int res)
		{
			var ret = int.TryParse(Console.ReadLine(), out res);
			if (ret == false)
				Console.WriteLine("invalid input");
			return ret;
		}

		public static bool ReadString(out string res)
		{
			res = Console.ReadLine();
			return true;
		}
	}
}