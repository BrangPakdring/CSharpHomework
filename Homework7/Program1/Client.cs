using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Client : Person
	{
		public Client() : base()
		{
            Id = Ids++;
        }

		public Client(string name) : base(name)
		{
            Id = Ids++;
		}

        public Client(Client client)
        {
            Id = client.Id;
            Name = client.Name;
        }

		public ulong Id { set; get; }
		public static ulong Ids = 893;

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
