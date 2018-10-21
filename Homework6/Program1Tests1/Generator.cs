using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Program1;

namespace Program1Tests1
{
    class Generator
    {
        private readonly static Random random = new Random();

        public static int MaxStringSize { set; get; } = 1000;

        public static int MaxOrderDetailsSize { set; get; } = 1000;

        internal static Order GetOrder()
        {
            var res = new Order(GetClient());
            var cnt = random.Next(MaxOrderDetailsSize);
            for (var i = 0; i < cnt; ++i)
            {
                res.AddOrderDetails(GetOrderDetails());
            }
            return res;
        }

        internal static Product GetProduct()
        {
            return new Product(GetRandomString(), (decimal)random.NextDouble() * short.MaxValue);
        }

        internal static Client GetClient()
        {
            return new Client(GetRandomString());
        }

        internal static OrderDetails GetOrderDetails()
        {
            return new OrderDetails(GetProduct(), (uint)(random.NextDouble() * uint.MaxValue));
        }

        private static string GetRandomString()
        {
            var r = random.NextDouble();
            if (r < 0.16) return "";
            if (r < 0.24) return string.Empty;
            var cnt = random.Next(0, MaxStringSize);
            StringBuilder res = new StringBuilder();
            for (var i = 0; i < cnt; ++i)
            {
                res.Append((char)random.Next('A', 'Z' + 1));
            }
            return res.ToString();
        }
    }
}
