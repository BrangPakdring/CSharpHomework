using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Runtime.InteropServices;

namespace Program2
{
	class Program
	{
		private static Order _order;

		static void Main(string[] args)
		{
			Console.WriteLine("Order Manager");
			_order = Order.GetInstance();

			var keys = new[]
				{"Exit", "Print Orders", "Add Order", "Remove Orders", "Modify Orders", "Search for Orders"};

			while (true)
			{
				Console.WriteLine("Keys:");
				for (var i = 0; i < keys.Length; ++i)
					Console.WriteLine($"{i} - {keys[i]}");
				var raw = Console.ReadLine();
				if (int.TryParse(raw, out var op) == false)
				{
					Console.Error.WriteLine("invalid input");
					continue;
				}
				else
				{
					switch (op)
					{
						case 0: return;
						case 1:
							PrintOrdersOptions();
							continue;
						case 2:
							AddOrdersOptions();
							continue;
						case 3:
							RemoveOrdersOptions();
							continue;
						case 4:
							ModifyOrdersOptions();
							continue;
						case 5:
							SearchForOrdersOptions();
							continue;
						default:
							Console.Error.WriteLine("invalid input");
							continue;
					}
				}
			}
		}

		private static void PrintOrdersOptions()
		{
			Console.WriteLine("Current order list:");
			_order.PrintOrders();
			Console.WriteLine($"{_order.Count()} orders in total");
		}

		private static void AddOrdersOptions()
		{
			Console.WriteLine("input product name:");
			var productName = Console.ReadLine();
			Console.WriteLine("input client name:");
			var clientName = Console.ReadLine();

			var details = new OrderDetails(productName, clientName);
			_order.AddOrder(details);

			Console.WriteLine($"Added order:\n{details}");
		}

		private static void RemoveOrdersOptions()
		{
			Console.WriteLine("Keys:");
			var keys = new[] {"Remove by ID", "Remove by Product Name", "Remove by Client Name"};
			for (var i = 0; i < keys.Length; ++i)
				Console.WriteLine($"{i} - {keys[i]}");

			InputOp:

			int op;
			while (int.TryParse(Console.ReadLine(), out op) == false)
				Console.Error.WriteLine("invalid input");

			List<OrderDetails> res;
			switch (op)
			{
				case 0:
					Console.WriteLine("input id:");
					long id;
					while (long.TryParse(Console.ReadLine(), out id) == false)
						Console.Error.WriteLine("invalid input");
					res = _order.RemoveOrderBy(OrderDetails.OrderDetailsType.OrderId, id);
					break;
				case 1:
					Console.WriteLine("input product name:");
					var productName = Console.ReadLine();
					res = _order.RemoveOrderBy(OrderDetails.OrderDetailsType.ProductName, productName);
					break;
				case 2:
					Console.WriteLine("input client name:");
					var clientName = Console.ReadLine();
					res = _order.RemoveOrderBy(OrderDetails.OrderDetailsType.ClientName, clientName);
					break;
				default:
					Console.Error.WriteLine("invalid input");
					goto InputOp;
			}

			foreach (var details in res)
			{
				Console.WriteLine(details);
			}
			Console.WriteLine($"removed {res.Count} orders in total");
		}

		private static void ModifyOrdersOptions()
		{
			Console.WriteLine("input id:");
			long id;
			while (long.TryParse(Console.ReadLine(), out id) == false)
				Console.Error.WriteLine("invalid input");

			var res = _order.FindOrderBy(OrderDetails.OrderDetailsType.OrderId, id);
			if (res.Count == 0)
			{
				Console.Error.WriteLine("no such order exists");
				return;
			}

			var target = res[0];
			Console.WriteLine($"found target original order:\n{target}");

			Console.WriteLine("input new product name:");
			var productName = Console.ReadLine();
			Console.WriteLine("input new client name:");
			var clientName = Console.ReadLine();

			var details = new OrderDetails(productName, clientName);
			_order.ModifyById(target.OrderId, details);

			Console.WriteLine($"Modified order:\n{details}");
		}

		private static void SearchForOrdersOptions()
		{
			Console.WriteLine("Keys:");
			var keys = new[] {"Search by ID", "Search by Product", "Search by Client Name"};
			for (var i = 0; i < keys.Length; ++i)
				Console.WriteLine($"{i} - {keys[i]}");

			InputOp:

			int op;
			while (int.TryParse(Console.ReadLine(), out op) == false)
				Console.Error.WriteLine("invalid input");
			List<OrderDetails> res;

			switch (op)
			{
				case 0:
					Console.WriteLine("input id:");
					long id;
					while (long.TryParse(Console.ReadLine(), out id) == false)
						Console.Error.WriteLine("invalid input");
					res = _order.FindOrderBy(OrderDetails.OrderDetailsType.OrderId, id);
					break;
				case 1:
					Console.WriteLine("input product name:");
					var productName = Console.ReadLine();
					res = _order.FindOrderBy(OrderDetails.OrderDetailsType.ProductName, productName);
					break;
				case 2:
					Console.WriteLine("input client name:");
					var clientName = Console.ReadLine();
					res = _order.FindOrderBy(OrderDetails.OrderDetailsType.ClientName, clientName);
					break;
				default:
					Console.Error.WriteLine("invalid input");
					goto InputOp;
			}

			foreach (var details in res)
			{
				Console.WriteLine(details);
			}
			Console.WriteLine($"found {res.Count} orders in total");
		}
	}
}