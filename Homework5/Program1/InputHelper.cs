using System;
using System.Reflection;

namespace Program1
{
	public class InputHelper
	{
		public static T Read<T>()
		{
			while (true)
			{
				var raw = Console.ReadLine();
				var t = typeof(T);
				var tryParse = t.GetMethod("TryParse",
					BindingFlags.Public | BindingFlags.Static,
					Type.DefaultBinder,
					new[]{typeof(string), t.MakeByRefType()},
					new[]{new ParameterModifier(2) });
				if (tryParse == null) throw new Exception();
				var parameters = new[]
					{raw, Activator.CreateInstance(t)};
				try
				{
					if ((bool) tryParse.Invoke(raw, parameters))
					{
						return (T) parameters[1];
					}
				}
				catch
				{
				}

				Console.Error.WriteLine("invalid input");
			}
		}
	}
}