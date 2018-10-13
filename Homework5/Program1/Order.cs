using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;

namespace Program1
{
	public class Order
	{
		private readonly OrderService
			_orderService = OrderService.GetInstance();

		private static long _globalOrderId = 114514L;

		#region Properties

		private List<OrderDetails> _list;

		public List<OrderDetails> OrderDetailsList
		{
			get => new List<OrderDetails>(_list);
			private set => _list = value;
		}

		public long OrderId { get; }

		private Client _client;

		public Client Client
		{
			get => new Client(_client);
			private set => _client = value;
		}

		#endregion

		public Order(Client client)
		{
			_list = new List<OrderDetails>();
			OrderId = _globalOrderId++;
			_client = client;
		}

		#region Operations

		public void AddDetails(OrderDetails details)
		{
			_list.Add(details);
		}

		public bool RemoveDetails(int index)
		{
			if (index <= 0 || index > _list.Count) return false;
			_list.RemoveAt(index - 1);
			return true;
		}

		#endregion

		public override string ToString()
		{
			var res = $"OrderId: {OrderId}\nClient: {Client.Name}\n";
			for (var i = 0; i < _list.Count; ++i)
			{
				res += $"#{i + 1,-4} : {_list[i]}\n";
			}

			return res;
		}
	}
}