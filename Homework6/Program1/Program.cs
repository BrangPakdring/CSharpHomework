// Yet another reconstructed project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	class Program
	{
		static readonly OrderService orderService = OrderService.GetInstance();

		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("(service) ");
				var largs = Console.ReadLine().ToLower().Trim().Split();
				try
				{
					switch (largs[0])
					{
						case "h":
						case "help":
							HelpOptions();
							break;
						case "q":
						case "quit":
							return;
						case "a":
						case "add":
							AddOptions();
							break;
						case "r":
						case "remove":
							RemoveOptions();
							break;
						case "f":
						case "find":
							FindOptions();
							break;
						case "m":
						case "modify":
							ModifyOptions();
							break;
						case "s":
						case "show":
							ShowOptions();
							break;
						default:
							throw new Exception("Invalid arguments");
					}
				}
				catch (Exception e)
				{
					Console.Error.WriteLine("Operation failed: " + e.Message);
					HelpOptions();
				}
			}
		}

		static void HelpOptions()
		{
			Console.WriteLine("Usage:" + "\n"
			                           + "help|h   Show this help" + "\n"
			                           + "quit|q   Quit" + "\n"
			                           + "add|a    Add an order" + "\n"
			                           + "remove|r Remove an order" + "\n"
			                           + "find|f   Find an order" + "\n"
			                           + "modify|m Modify an order" + "\n"
			                           + "show|s   Show orders" + "\n");
		}

		static void AddOptions(bool once = false)
		{
			Console.WriteLine("Client:");
			Console.Write(">>> ");
			var clientName = Console.ReadLine();
			Client client = new Client(clientName);
			Order order = new Order(client);
			Console.WriteLine("Usage:");
			Console.WriteLine("[PRODUCTNAME] [PRODUCTPRICE] [COUNT]");
			while (true && !once)
			{
				Console.Write(">>> ");
				var line = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(line)) break;
				var largs = line.Trim().Split();
				OrderDetails orderDetails = new OrderDetails(new Product(largs[0], decimal.Parse(largs[1])), uint.Parse(largs[2]));
				order.AddOrderDetails(orderDetails);
			}

			orderService.AddOrder(order);
		}

		static void RemoveOptions()
		{
			Console.WriteLine("Input client name / client Id / order Id:");
			while (true)
			{
				Console.Write(">>> ");
				var line = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(line)) break;
				bool res = orderService.RemoveAll(order => order.Client.Name == line || order.Client.Id.ToString() == line || order.Id.ToString() == line);
				if (res == false) throw new Exception("No such order exists.");
			}
		}

		static void FindOptions()
		{
			Console.WriteLine("Usage:");
			Console.WriteLine("cost|c [COST]  cost greater than COST" + "\n"
			                                                          + "client|l [NAME]    client name equals NAME" + "\n");
			while (true)
			{
				Console.Write(">>> ");
				var line = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(line)) break;
				var largs = line.Trim().Split();
				List<Order> res = new List<Order>();
				switch (largs[0].ToLower())
				{
					case "c":
					case "cost":
						res = (from order in orderService.GetList() where order.Cost > decimal.Parse(largs[1]) select order).ToList();
						break;
					case "l":
					case "client":
						res = orderService.GetList().Where(order => order.Client.Name == largs[1]).ToList();
						break;
					default:
						throw new Exception("Invalid arguments");
				}

				foreach (var order in res)
				{
					Console.WriteLine(order);
				}
			}
		}

		static void ModifyOptions()
		{
			Console.WriteLine("Input order Id:");
			Console.Write(">>> ");
			var id = ulong.Parse(Console.ReadLine());
			orderService.RemoveAll(order => order.Id == id);
			AddOptions(true);
		}

		static void ShowOptions()
		{
			foreach (var order in orderService.GetList())
			{
				Console.WriteLine(order);
			}
		}
	}
}
