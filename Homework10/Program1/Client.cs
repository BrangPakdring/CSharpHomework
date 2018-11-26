using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Client
	{
		[Key]
		public string Id { set; get; }
		public string Name { set; get; }
		public string PhoneNumber { set; get; }
		public static ulong Ids = (ulong)DateTime.Now.Ticks % 1000000;

		public Client() : base()
		{
		}

		public Client(string name)
		{
			Name = name;
			Id = Ids++.ToString();
		}

		public Client(Client client, string phoneNumber = "")
		{
			Id = client.Id;
			Name = client.Name;
			PhoneNumber = phoneNumber;
		}

		public override string ToString()
		{
			return $"{Name}";
		}

		public override bool Equals(object obj)
		{
			return obj is Client client &&
				   base.Equals(obj) &&
				   Id == client.Id;
		}

		public override int GetHashCode()
		{
			var hashCode = 1545243542;
			hashCode = hashCode * -1521134295 + base.GetHashCode();
			hashCode = hashCode * -1521134295 + Id.GetHashCode();
			return hashCode;
		}
	}
}
