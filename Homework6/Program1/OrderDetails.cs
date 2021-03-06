﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class OrderDetails
	{
		public Product Product { set; get; }
		public uint Count { set; get; }
		public decimal Cost => Count * Product.Price;

		private OrderDetails()
		{
		}

		public OrderDetails(Product product, uint count = 1)
		{
			Product = product;
			Count = count;
		}

		public override string ToString()
		{
			return $"Product: {Product,-20} | Count: {Count,-10} | Cost: {Cost,10}$";
		}

        public override bool Equals(object obj)
        {
            return obj is OrderDetails details &&
                   EqualityComparer<Product>.Default.Equals(Product, details.Product) &&
                   Count == details.Count &&
                   Cost == details.Cost;
        }

        public override int GetHashCode()
        {
            var hashCode = 738199192;
            hashCode = hashCode * -1521134295 + EqualityComparer<Product>.Default.GetHashCode(Product);
            hashCode = hashCode * -1521134295 + Count.GetHashCode();
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }
    }
}
