using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.DeliveryMethods.Couriers
{
    public class DeliveryCompany : BaseCourier
    {
        public string CompanyName { get; set; }
        public override string Details => $"Delivery company \"{CompanyName}\"";
    }
}
