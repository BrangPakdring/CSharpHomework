using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Client : Person
	{
		private Client() : base(null)
		{
		}

		public Client(string name) : base(name)
		{
		}

		public ulong Id { set; get; } = _ids++;
		public static ulong _ids = 893;

		public override string ToString()
		{
			return $"{Name}";
		}
	}
}
