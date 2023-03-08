using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Module7.OrderAggregate;
using Module7.DeliveryMethods.Couriers;

namespace Module7.DeliveryMethods
{
    public class HomeDelivery<TCourier> : DeliveryMethod where TCourier : BaseCourier, new()
    {
        public HomeDelivery()
        {
            Courier = new TCourier();
        }

        public TCourier Courier { get; }

        public override string Details => $"Home delivery - {Courier.Details}\n" + base.Details;


    }
}
