using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    public class Client : Person
    {
        private Client():base(null) { }
        public Client(string name) : base(name) { }
        public ulong Id { set; get; } = Ids++;
        public static ulong Ids = 893;

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
