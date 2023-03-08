using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Module7.OrderAggregate
{
    public class Address
    {
        public Address()
        {
        }

        public Address(string country, string state, string city, string street)
        {
            Country = country;
            State = state;
            City = city;
            Street = street;
        }

        public string Country { get; init; }
        public string State { get; init; }
        public string City { get; init; }
        public string Street { get; init; }

        public override string ToString()
        {
            return string.Format($"{Country}, {State}, {City}, {Street}");
        }
    }
}
