using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module7.OrderAggregate;

namespace Module7
{
    public static class Extensions
    {
        public static string ExFormat(this Address address)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(
                $"*Delivery Address*\n" +
                $"Country:\t{address.Country}\n" +
                $"State:\t\t{address.State}\n" +
                $"City:\t\t{address.City}\n" +
                $"Street:\t\t{address.Street}");
            return sb.ToString();
        }
    }
}
