using System;

namespace Program2
{
	public class OrderDetails
	{
		public enum OrderDetailsType
		{
			OrderId,
			ProductName,
			ClientName,
		}
		
		private static long _currentOrderId = 1919810114514L;

		public OrderDetails(string productName, string clientName)
		{
			OrderId = _currentOrderId++;
			ProductName = productName;
			ClientName = clientName;
		}

		public long OrderId { get; }

		public string ProductName { get; }

		public string ClientName { get; }

		public override string ToString()
		{
			return string.Format("#{0, -16} | Product: {1, -16} | Client: {2, -16}", OrderId, ProductName, ClientName);
		}
	}
}