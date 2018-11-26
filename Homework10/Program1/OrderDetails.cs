using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Program1
{
	public class OrderDetails
	{
        [Key]
        public string Id { set; get; }
		public string ProductName { set; get; }
		public decimal ProductPrice { set; get; }
		public uint Count
		{
			get; set;
		}
		public decimal Cost => Count * ProductPrice;

		public OrderDetails()
		{
		}

		public OrderDetails(string id, string productName, decimal productPrice, uint count = 1)
		{
			Id = id;
			ProductName = productName;
			ProductPrice = productPrice;
			Count = count;
		}

		public override string ToString()
		{
			var product = $"{ ProductName, -10 } { ProductPrice, 10}";
			return $"Product: {product,-20} | Count: {Count,-10} | Cost: {Cost,10}$";
		}

		public override bool Equals(object obj)
		{
			return obj is OrderDetails details &&
				   ProductName == details.ProductName &&
				   ProductPrice == details.ProductPrice &&
				   Count == details.Count &&
				   Cost == details.Cost;
		}

		public override int GetHashCode()
		{
			var hashCode = 738199192;
			hashCode = hashCode * -1521134295 + ProductName.GetHashCode();
			hashCode = hashCode * -1521134295 + ProductPrice.GetHashCode();
			hashCode = hashCode * -1521134295 + Count.GetHashCode();
			hashCode = hashCode * -1521134295 + Cost.GetHashCode();
			return hashCode;
		}
	}
}
