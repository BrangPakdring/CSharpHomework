using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Program2
{
	public class Order
	{
		private readonly OrderService _orderService;

		private static Order _sharedOrder;

		private Order()
		{
			if (_orderService == null)
				_orderService = OrderService.GetInstance();
		}

		public static Order GetInstance()
		{
			return _sharedOrder ?? (_sharedOrder = new Order());
		}

		public void AddOrder(OrderDetails details)
		{
			_orderService.Add(details);
		}

		public List<OrderDetails> RemoveOrder(OrderDetails details)
		{
			return _orderService.RemoveAll(details2 => details2.Equals(details));
		}

		private List<OrderDetails> RemoveOrderById(long id)
		{
			return _orderService.RemoveAll(details => details.OrderId == id);
		}

		private List<OrderDetails> RemoveOrderByProduct(string productName)
		{
			return _orderService.RemoveAll(details => details.ProductName == productName);
		}

		private List<OrderDetails> RemoveOrderByClient(string clientName)
		{
			return _orderService.RemoveAll(details => details.ClientName == clientName);
		}

		public List<OrderDetails> RemoveOrderBy(OrderDetails.OrderDetailsType type, object content)
		{
			switch (type)
			{
				case OrderDetails.OrderDetailsType.OrderId:
					if (content is long l)
						return RemoveOrderById(l);
					else break;
				case OrderDetails.OrderDetailsType.ClientName:
					if (content is string s)
						return RemoveOrderByClient(s);
					else break;
				case OrderDetails.OrderDetailsType.ProductName:
					if (content is string s1)
						return RemoveOrderByProduct(s1);
					else break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}

			return default(List<OrderDetails>);
		}

		private List<OrderDetails> FindOrderById(long id)
		{
			return _orderService.FindAll(details => details.OrderId == id);
		}

		private List<OrderDetails> FindOrderByClient(string clientName)
		{
			return _orderService.FindAll(details => details.ClientName == clientName);
		}

		private List<OrderDetails> FindOrderByProduct(string productName)
		{
			return _orderService.FindAll(details => details.ProductName == productName);
		}

		public List<OrderDetails> FindOrderBy(OrderDetails.OrderDetailsType type, object content)
		{
			switch (type)
			{
				case OrderDetails.OrderDetailsType.OrderId:
					if (content is long l)
						return FindOrderById(l);
					else break;
				case OrderDetails.OrderDetailsType.ClientName:
					if (content is string s)
						return FindOrderByClient(s);
					else break;
				case OrderDetails.OrderDetailsType.ProductName:
					if (content is string s1)
						return FindOrderByProduct(s1);
					else break;
				default:
					throw new ArgumentOutOfRangeException(nameof(type), type, null);
			}

			return default(List<OrderDetails>);
		}

		public bool ModifyById(long id, OrderDetails details)
		{
			return _orderService.ModifyAt
			(
				_orderService.IndexOf(details2 => details2.OrderId == id),
				details
			);
		}

		public void PrintOrders()
		{
			var list = _orderService.GetList();
			foreach (var details in list)
			{
				Console.WriteLine(details);
			}
		}

		public int Count() => _orderService.Count();
	}
}