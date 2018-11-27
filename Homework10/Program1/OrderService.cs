using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace Program1
{
	public class OrderService
	{
		#region Construct Service

		private OrderService()
		{
			LoadServiceStatus();
			LoadData();
//			ImportList();
		}

		~OrderService()
		{
			SaveServiceStatus();
//			ExportList();
		}

		private static OrderService _instance;

		public static OrderService GetInstance() => _instance ?? (_instance = new OrderService());

		#endregion

		private static readonly string StatusPath = "./.ServiceStatus";

		public string SavingPath { set; get; }

		private List<Order> _list { set; get; } = new List<Order>();

		public List<Order> List
		{
			set
			{
				throw new NotImplementedException();
			}
			get
			{
				using (var db = new OrderDb())
					return db.Orders.Include("Client").Include("List").ToList();
			}
		}
		
		public void AddOrder(Order order)
		{
			using (var db = new OrderDb())
			{
				db.Orders.Add(order);
				db.SaveChanges();
			}
		}

//		public bool RemoveOrder(int index)
//		{
//			if (index < 0 || index >= _list.Count) return false;
//			_list.RemoveAt(index);
//			return true;
//		}

		public bool RemoveOrder(Order order)
		{
			using (var db = new OrderDb())
			{
				try
				{
					var target = db.Orders.Include("List").Include("Client").SingleOrDefault(o => o.Id == order.Id);
					db.OrderDetails.RemoveRange(target.List);
					db.Orders.Remove(target);
					db.SaveChanges();
					return true;
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					return false;
				}
			}
		}

		//public bool RemoveAll(Predicate<Order> match)
		//{
		//	bool res = false;
		//	for (var i = 0; i < _list.Count; ++i)
		//	{
		//		if (!match(_list[i])) continue;
		//		res = true;
		//		_list.RemoveAt(i--);
		//	}

		//	return res;
		//}

		public bool RemoveAll(Predicate<Order> match)
		{
			using (var db = new OrderDb())
			{
				try
				{
					foreach (var order in db.Orders.AsEnumerable().Where(o => match(o)))
					{
						RemoveOrder(order);
					}
					db.SaveChanges();
					return true;
				}
				catch (Exception e)
				{
					Console.Error.WriteLine(e);
					return false;
				}
			}
		}

		//		public List<Order> FindAll(Predicate<Order> match)
		//			=> (from order in _list where match(order) select order).ToList();
		public List<Order> FindAll(Predicate<Order> match)
		{
			using (var db = new OrderDb())
			{
				//				
				var s = db.Orders.Include("List").Include("Client").AsEnumerable().Where(o => match(o));
				//				var t = s.ToList();
				return s.ToList();
			}
		}

		//public bool ModifyOrder(int index, Order order)
		//{
		//	if (index < 0 || index >= _list.Count) return false;
		//	_list[index] = order;
		//	return true;
		//}

		//public bool ModifyOrder(int index, Order order)
		//{
		//	if (index < 0 || index >= _list.Count) return false;

		//	return true;
		//}

		public void ExportHTML(string pathXML, string pathXSLT, string pathHTML)
		{
			try
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(pathXML);

				XPathNavigator xPathNavigator = xmlDocument.CreateNavigator();
				xPathNavigator.MoveToRoot();

				XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
				xslCompiledTransform.Load(pathXSLT);

                using (FileStream fileStream = File.OpenWrite(pathHTML))
                {
                    XmlTextWriter xmlTextWriter = new XmlTextWriter(fileStream, Encoding.Default);
                    xslCompiledTransform.Transform(xPathNavigator, null, xmlTextWriter);
                }
			}
			catch(XmlException e)
			{
				Console.Error.WriteLine(e);
			}
			catch (XsltException e)
			{
				Console.Error.WriteLine(e);
			}
		}

		public void ExportList(string path = null)
		{
			if (path != null) SavingPath = path;
			var xmlSerializer = new XmlSerializer(List.GetType());
			using (var fileStream = new FileStream(SavingPath, FileMode.Create))
				xmlSerializer.Serialize(fileStream, List);
		}

		public void ImportList(string path = null)
		{
			if (path != null) SavingPath = path;
			var xmlSerializer = new XmlSerializer(List.GetType());
			if (File.Exists(SavingPath) == false) return;
			using (var fileStream = new FileStream(SavingPath, FileMode.Open))
				List = (List<Order>)xmlSerializer.Deserialize(fileStream);
		}

		private void SaveServiceStatus()
		{
			using (var streamWriter = new StreamWriter(StatusPath))
			{
				streamWriter.WriteLine(SavingPath);
//				streamWriter.WriteLine(Order.Ids);
//				streamWriter.WriteLine(Client.Ids);
			}
		}

		private void LoadServiceStatus()
		{
			try
			{
				using (var streamReader = new StreamReader(StatusPath))
				{
					SavingPath = streamReader.ReadLine();
//					Order.Ids = Convert.ToString(streamReader.ReadLine());
//					Client.Ids = Convert.ToUInt64(streamReader.ReadLine());
				}
			}
			catch
			{
				SavingPath = "./tmp.xml";
			}
		}
		
		private void LoadData()
		{
		}
	}
}
