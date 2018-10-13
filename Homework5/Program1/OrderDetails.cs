using System;

namespace Program1
{
	public class OrderDetails
	{
		public enum DetailsType
		{
			ProductName,
			Cost,
		}

		public OrderDetails(string productName, decimal cost)
		{
			ProductName = productName;
			Cost = cost;
		}

		public string ProductName { get; }

		public decimal Cost { get; }

		public override string ToString() =>
			$"Product: {ProductName,-16} | Cost : {Cost,-16}";
	}
}