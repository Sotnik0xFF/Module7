using System;
using System.Runtime.CompilerServices;
using Module7.DeliveryMethods;
using Module7.DeliveryMethods.Couriers;
using Module7.OrderAggregate;

namespace Module7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeliveryMethod homeDeliveryByCompany = MakeHomeDeliveryByCompany(
                new Address("Respublika Krakozhiya", "", "Pretoska", "Lenina, 50a"),
                "Horns and hooves Corp.");

            Order order = new Order(homeDeliveryByCompany);

            order.AddItem("Koza pills", 100);
            Console.WriteLine(order.Description);
        }

        public static DeliveryMethod MakeHomeDeliveryByCompany(Address address, string companyName)
        {
            var result = new HomeDelivery<DeliveryCompany>();
            result.Address = address;
            result.Courier.CompanyName = companyName;
            return result;
        }

        public static DeliveryMethod MakeHomeDeliveryByDeliverymen(Address address, string deliverymenName)
        {
            var result = new HomeDelivery<Deliverymen>();
            result.Address = address;
            result.Courier.Name = deliverymenName;
            return result;
        }

    }
}
