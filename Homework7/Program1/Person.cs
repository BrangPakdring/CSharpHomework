using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Person
	{
		public string Name { get; set; }

		public Person()
		{
		}

		public Person(string name)
		{
			Name = name;
		}

		public override bool Equals(object obj)
		{
			return obj is Person person &&
				   Name == person.Name;
		}

		public override int GetHashCode()
		{
			return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
		}
	}
}
