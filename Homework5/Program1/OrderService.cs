using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace Program1
{
	public class OrderService
	{
		private static OrderService _sharedOrderService;

		public static OrderService GetInstance() => _sharedOrderService ??
		                                         (_sharedOrderService =
			                                         new OrderService());

		private readonly List<Order> _list = new List<Order>();

		public List<Order> GetOrderList() => new List<Order>(_list);

		private OrderService()
		{
		}

		public bool AddOrder(Order details)
		{
			if (_list.Contains(details)) return false;
			_list.Add(details);
			return true;
		}

		public List<Order> RemoveAll(Predicate<Order> match)
		{
			var res = new List<Order>();
			for (var i = 0; i < _list.Count; ++i)
			{
				if (!match(_list[i])) continue;
				res.Add(_list[i]);
				_list.RemoveAt(i--);
			}

			return res;
		}

		public List<Order> FindAll(Predicate<Order> match)
		{
			return _list.Where(order => match(order)).ToList();
		}

		public bool ModifyAt(int index, Order order)
		{
			if (index >= _list.Count || index < 0) return false;
			_list[index] = order;
			return true;
		}

		public int Count => _list.Count;
	}
}