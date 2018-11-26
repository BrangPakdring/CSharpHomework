using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Program1
{
    class OrderDb : DbContext
    {
        public OrderDb() : base("OrderDb") { }
        public DbSet<Order> Orders { set; get; }
        public DbSet<OrderDetails> OrderDetails { set; get; }
		public DbSet<Client> Clients { set; get; }
    }
}
