using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.OrderAggregate
{
    public class Product
    {
        public Product()
        {
        }

        public Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
