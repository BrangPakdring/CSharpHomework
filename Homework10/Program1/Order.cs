using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Key]
		public string Id { set; get; } = DateTime.Now.ToString("yyyyMMddfff");
//        public static string Ids { set; get; }
        private decimal _cost = 0;
		public decimal Cost
		{
			set => _cost = value;
			get
			{
				try
				{
					return _cost = List.Sum(orderDetails => orderDetails.Cost);
				}
				catch (NullReferenceException)
				{
					return _cost = 0;
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
//			Id = Ids++;
		}

/*		public static bool IsIdValid(string idString)
		{
			if (idString.Length != 11 || ulong.TryParse(idString, out ulong id) == false) return false;
			ulong yyyy = id / 10000000L, MM = id % 10000000L / 100000L, dd = id % 100000L / 1000L;
			bool leap = (yyyy % 400 == 0 || yyyy % 4 == 0 && yyyy % 100 != 0);
			var days = new ulong[] { 0, 31, (ulong)(leap ? 29 : 28), 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (MM < 1 || MM > 12) return false;
			if (dd < 1 || dd > days[MM]) return false;
//			_ids = idString;
			return true;
		}*/

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
			return Id.GetHashCode();
		}
	}
}
