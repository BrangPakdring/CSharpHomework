using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Program1
{
	public class OrderService
	{
		#region Constructor and instance

		private OrderService()
		{
			ReadStatus();
		}

		~OrderService()
		{
			SaveStatus();
		}

		private static OrderService _instance;

		public static OrderService GetInstance() => _instance ?? (_instance = new OrderService());

		#endregion

		public string SavingPath { set; get; } = "./OrderService.xml";

		List<Order> _list = new List<Order>();

		public List<Order> GetList() => new List<Order>(_list);

		public void AddOrder(Order order) => _list.Add(order);

		public bool RemoveOrder(int index)
		{
			if (index < 0 || index >= _list.Count) return false;
			_list.RemoveAt(index);
			return true;
		}

		public bool RemoveAll(Predicate<Order> match)
		{
			bool res = false;
			for (var i = 0; i < _list.Count; ++i)
			{
				if (!match(_list[i])) continue;
				res = true;
				_list.RemoveAt(i--);
			}

			return res;
		}

		public List<Order> FindAll(Predicate<Order> match)
			=> (from order in _list where match(order) select order).ToList();

		public bool ModifyOrder(int index, Order order)
		{
			if (index < 0 || index >= _list.Count) return false;
			_list[index] = order;
			return true;
		}

		public void SaveStatus()
		{
			var xmlSerializer = new XmlSerializer(_list.GetType());
			using (var fileStream = new FileStream(SavingPath, FileMode.Create))
				xmlSerializer.Serialize(fileStream, _list);
		}

		public void ReadStatus()
		{
			if (!File.Exists(SavingPath)) return;
			var xmlSerializer = new XmlSerializer(_list.GetType());
			using (var fileStream = new FileStream(SavingPath, FileMode.Open))
				_list = (List<Order>) xmlSerializer.Deserialize(fileStream);
		}

		public void ClearStatus()
		{
			if (File.Exists(SavingPath)) File.Delete(SavingPath);
            _instance._list.Clear();
		}
	}
}
