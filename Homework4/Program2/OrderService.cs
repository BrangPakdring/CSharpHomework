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
		
		public List<OrderDetails> GetList()
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

		public int RemoveAll(Predicate<OrderDetails> match)
		{
			return _list.RemoveAll(match);
		}

		public List<OrderDetails> FindAll(Predicate<OrderDetails> match)
		{
			return _list.FindAll(match);
		}

		public bool ModifyAt(int index, OrderDetails details)
		{
			if (_list.Count <= index) return false;
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