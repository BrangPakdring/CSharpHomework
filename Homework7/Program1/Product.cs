using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Product
	{
        public string Name { set; get; } = "";
        public decimal Price { set; get; } = 0;

		public Product()
		{
		}

		public Product(string name, decimal price)
		{
			Name = name;
			Price = price;
		}

		public override string ToString()
		{
			return $"{Name,-10} {Price,10}$";
		}

        public override bool Equals(object obj)
        {
            return obj is Product product &&
                   Name == product.Name &&
                   Price == product.Price;
        }

        public override int GetHashCode()
        {
            var hashCode = -44027456;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Price.GetHashCode();
            return hashCode;
        }
    }
}
