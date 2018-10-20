using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Product
    {
        public string Name { set; get; }
        public decimal Price { set; get; }

        private Product() { }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name,-10} {Price,10}$";
        }
    }
}
