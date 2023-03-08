using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.DeliveryMethods.Couriers
{
    public class Deliverymen : BaseCourier
    {
        public Deliverymen()
        {
        }

        public Deliverymen(string name)
        {
        }

        public string Name { get; set; }

        public override string Details => "Доставка курьером." + Environment.NewLine + $"Имя курьера: {Name}";
    }
}
