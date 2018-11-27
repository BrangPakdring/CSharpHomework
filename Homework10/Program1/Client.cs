using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Client
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long Id { set; get; }

		[MaxLength(32)]
		public string Name { set; get; }

		[StringLength(11)]
		public string PhoneNumber { set; get; }

		public Client()
		{
		}

		public Client(Client client)
		{
			Id = client.Id;
			Name = client.Name;
			PhoneNumber = client.PhoneNumber;
		}

		public Client(string name)
		{
			Name = name;
		}

		public Client(Client client, string phoneNumber)
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
			return hashCode;
		}
	}
}
