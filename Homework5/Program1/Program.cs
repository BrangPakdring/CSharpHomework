// I'd misunderstood what order meant and this is a reconstructed program from
// the last one.

using System;
using System.Collections.Generic;
using System.Linq;

namespace Program1
{
	class Program
	{
		private static OrderService _orderService = OrderService.GetInstance();

		static void Main(string[] args)
		{
			// add order test 1

			Console.WriteLine("add order test 1");
			var order1 = new Order(new Client("Dijkstra"));
			var details1 = new OrderDetails("SP", 1919);
			var details2 =
				new OrderDetails("Shortest Path", 810);
			order1.AddDetails(details1);
			order1.AddDetails(details2);
			Console.WriteLine(order1);
			order1.RemoveDetails(3);
			order1.RemoveDetails(2);
			Console.WriteLine(order1);


			// add order test 2

			Console.WriteLine("add order test 2");
			var order2 = new Order(new Client("Tarjan"));
			var details3 = new OrderDetails("LCA", 810);
			var details4 = new OrderDetails("Lowest Common Ancestor", 1919);
			order2.AddDetails(details3);
			order2.AddDetails(details4);
			order2.AddDetails(details3);
			Console.WriteLine(order2);

			// add order test 3

			Console.WriteLine("add order test 3");
			var order3 = new Order(new Client("Floyd"));
			var details5 = new OrderDetails("SP", 1919);
			var details6 =
				new OrderDetails("Shortest Path", 1919810);
			order3.AddDetails(details5);
			order3.AddDetails(details6);
			_orderService.AddOrder(order3);

			// show list test 1
			{
				Console.WriteLine("show list test 1");
				_orderService.AddOrder(order1);
				var orderList = _orderService.GetOrderList();
				foreach (var order in orderList)
				{
					Console.WriteLine(order);
				}
			}

			// show list test 2
			{
				Console.WriteLine("show list test 2");
				_orderService.AddOrder(order2);
				_orderService.AddOrder(order2);
				var orderList = _orderService.GetOrderList();
				foreach (var order in orderList)
				{
					Console.WriteLine(order);
				}
			}

			// find orders by their ids
			{
				Console.WriteLine("find orders by their ids");
				var queryOrderId =
					_orderService.GetOrderList()
						.Where(orderList => orderList.OrderId == 114514)
						.ToArray();
				foreach (var order in queryOrderId)
				{
					Console.WriteLine(order);
				}
			}

			// find orders by clients' name
			{
				Console.WriteLine("find orders by clients' name");
				var queryClient =
					_orderService.FindAll(
						order => order.Client.Name == "Tarjan");
				foreach (var order in queryClient)
				{
					Console.WriteLine(order);
				}
			}

			// find orders by products' name
			{
				Console.WriteLine("find orders by products' name");
				var queryProduct =
					from order in _orderService.GetOrderList()
					where order.OrderDetailsList.Exists(orderDetails =>
						orderDetails.ProductName == "SP")
					select order;
				foreach (var order in queryProduct)
				{
					Console.WriteLine(order);
				}
			}

			// find orders by costs greater than 10000
			{
				Console.WriteLine(
					"find orders by total cost greater than 10000");
				var queryCost = _orderService.GetOrderList()
					.Where(order =>
						order.OrderDetailsList.Sum(details => details.Cost) >
						10000);
				foreach (var order in queryCost)
				{
					Console.WriteLine(order);
				}
			}
		}
	}
}