using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;

namespace Program2
{
	public class OrderService
	{
		private static OrderService _sharedOrderService;

		public static OrderService GetInstance()
		{
			return _sharedOrderService ?? (_sharedOrderService = new OrderService());
		}

		private readonly List<OrderDetails> _list;
		
		public IEnumerable<OrderDetails> GetList()
		{
			return new List<OrderDetails>(_list);
		}

		private OrderService()
		{
			if (_list == null)
				_list = new List<OrderDetails>();
		}

		public void Add(OrderDetails details)
		{
			_list.Add(details);
		}

		public List<OrderDetails> RemoveAll(Predicate<OrderDetails> match)
		{
			var res = new List<OrderDetails>();
			for (var i = 0; i < _list.Count; ++i)
			{
				if (!match(_list[i])) continue;
				res.Add(_list[i]);
				_list.RemoveAt(i--);
			}

			return res;
		}

		public List<OrderDetails> FindAll(Predicate<OrderDetails> match)
		{
			return _list.FindAll(match);
		}

		public bool ModifyAt(int index, OrderDetails details)
		{
			if (index >= _list.Count || index < 0) return false;
			_list[index] = details;
			return true;
		}

		public int IndexOf(Predicate<OrderDetails> match)
		{
			return _list.FindIndex(match);
		}

		public int Count()
		{
			return _list.Count;
		}
	}
}