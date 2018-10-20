using System;
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
	}
}
