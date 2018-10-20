using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Order
    {
        public readonly List<OrderDetails> list = new List<OrderDetails>();
        public List<OrderDetails> GetList() => new List<OrderDetails>(list);
        public Client Client { set; get; }
        public ulong Id { set; get; } = Ids++;
        private static ulong Ids = 1919810114514;
        public decimal Cost => list.Sum(orderDetails => orderDetails.Cost);

        private Order() { }

        public Order(Client client)
        {
            Client = client;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder($"#{Id}\nClient: {Client}\n");
            foreach(var orderDetails in list)
            {
                stringBuilder.AppendLine(orderDetails.ToString());
            }
            return stringBuilder.ToString();
        }

        public void AddOrderDetails(OrderDetails orderDetails)
        {
            list.Add(orderDetails);
        }

        public bool RemoveOrderDetails(int index)
        {
            if (index < 0 || index > list.Count) return false;
            list.RemoveAt(index);
            return true;
        }
    }
}
