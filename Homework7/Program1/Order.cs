using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
	public class Order
	{
		public List<OrderDetails> List { set; get; } = new List<OrderDetails>();
		public Client Client { set; get; } = new Client();
		public ulong Id { set; get; }
		private static ulong _ids;
		public static ulong Ids
		{
			set => _ids = Ids;
			get
			{
				var time = DateTime.Now;
				var res = Convert.ToUInt64(time.ToString("yyyyMMddHHmmssfff"));
				return res;
			}
		}
		public decimal Cost
		{
			get
			{
				try
				{
					return List.Sum(orderDetails => orderDetails.Cost);
				}
				catch (NullReferenceException)
				{
					return 0;
				}
			}
		}

		public Order()
		{
		}

		public Order(Order order)
		{
			List = new List<OrderDetails>(order.List);
			Client = new Client(order.Client);
			Id = order.Id;
		}

		public Order(Client client)
		{
			Client = client;
			Id = Ids++;
		}

		public void AddOrderDetails(OrderDetails orderDetails)
		{
			List.Add(orderDetails);
		}

		public bool RemoveOrderDetails(int index)
		{
			if (index < 0 || index > List.Count) return false;
			List.RemoveAt(index);
			return true;
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder($"#{Id}\nClient: {Client}\n");
			foreach (var orderDetails in List)
			{
				stringBuilder.AppendLine(orderDetails.ToString());
			}

			return stringBuilder.ToString();
		}

		public override bool Equals(object obj)
		{
			return obj is Order order &&
				   //EqualityComparer<List<OrderDetails>>.Default.Equals(List, order.List) &&
				   List.SequenceEqual(order.List) &&
				   EqualityComparer<Client>.Default.Equals(Client, order.Client) &&
				   Id == order.Id &&
				   Cost == order.Cost;
		}

		public override int GetHashCode()
		{
/*			var hashCode = -1948411825;
			hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetails>>.Default.GetHashCode(List);
			hashCode = hashCode * -1521134295 + EqualityComparer<Client>.Default.GetHashCode(Client);
			hashCode = hashCode * -1521134295 + Id.GetHashCode();
			hashCode = hashCode * -1521134295 + Cost.GetHashCode();
			return hashCode;*/
			return (int)Id % int.MaxValue;
		}
	}
}
