using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.OrderAggregate
{
    public abstract class DeliveryMethod
    {
        private Address address;

        public DeliveryMethod()
        {
        }

        public DeliveryMethod(Address adress)
        {
            Address = adress;
        }

        public Address Address
        {
            get
            {
                if (address == null)
                {
                    address = new Address();
                }
                return address;
            }
            set => address = value;
        }
        public abstract string Details { get; }
    }
}
