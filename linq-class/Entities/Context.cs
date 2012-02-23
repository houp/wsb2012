using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace linq_class.Entities
{
    public class Context
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Client> Clients { get; set; }
    }
}
