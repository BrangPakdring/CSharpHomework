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
		#region Construct Service

		private OrderService()
		{
			LoadServiceStatus();
			ImportList();
		}

		~OrderService()
		{
			SaveServiceStatus();
			ExportList();
		}

		private static OrderService _instance;

		public static OrderService GetInstance() => _instance ?? (_instance = new OrderService());

		#endregion

		private static readonly string StatusPath = "./.ServiceStatus";

		public static string SavingPath { set; get; }

		private List<Order> _list { set; get; } = new List<Order>();

		public List<Order> List { get => new List<Order>(_list); }

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

		public void ExportList(string path = null)
		{
			if (path != null) SavingPath = path;
			var xmlSerializer = new XmlSerializer(_list.GetType());
			using (var fileStream = new FileStream(SavingPath, FileMode.Create))
				xmlSerializer.Serialize(fileStream, _list);
		}

		public void ImportList(string path = null)
		{
			if (path != null) SavingPath = path;
			var xmlSerializer = new XmlSerializer(_list.GetType());
			if (File.Exists(SavingPath) == false) return;
			using (var fileStream = new FileStream(SavingPath, FileMode.Open))
				_list = (List<Order>)xmlSerializer.Deserialize(fileStream);
		}

		public void ClearList(string path = null)
		{
			if (path != null) SavingPath = path;
			if (File.Exists(SavingPath)) File.Delete(SavingPath);
			_instance._list.Clear();
		}

		private void SaveServiceStatus()
		{
			using (var streamWriter = new StreamWriter(StatusPath))
			{
				streamWriter.WriteLine(SavingPath);
				streamWriter.WriteLine(Order.Ids);
				streamWriter.WriteLine(Client.Ids);
			}
		}

		private void LoadServiceStatus()
		{
			try
			{
				using (var streamReader = new StreamReader(StatusPath))
				{
					SavingPath = streamReader.ReadLine();
					Order.Ids = Convert.ToUInt64(streamReader.ReadLine());
					Client.Ids = Convert.ToUInt64(streamReader.ReadLine());
				}
			}
			catch
			{
				SavingPath = "./tmp.xml";
			}
		}
	}
}
