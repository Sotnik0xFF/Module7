using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module7.OrderAggregate;

namespace Module7
{
    public static class OrderFactory
    {
        public static Order Make<TDelivery>() where TDelivery : DeliveryMethod, new()
        {
            return new Order(new TDelivery());
        }
    }
}
