using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module7.OrderAggregate
{
    public class Order : BaseEntity<int>
    {
        private List<OrderItem> items;

        public Order(DeliveryMethod deliveryMethod)
        {
            items = new List<OrderItem>();
            DeliveryMethod = deliveryMethod;
        }

        public Order(int id, DeliveryMethod deliveryMethod) : this(deliveryMethod)
        {
            Id = id;
        }

        public OrderItem this[int index] => items[index];
        public int ItemsCount => items.Count;
        public DeliveryMethod DeliveryMethod { get; set; }
        public string Description
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Order details");
                foreach ( OrderItem item in items )
                {
                    sb.AppendLine($"---{item.Product.Name}\t{item.Count}");
                }
                sb.AppendLine(DeliveryMethod.Details);

                return sb.ToString();
            }
        }

        public void AddItem(string productName, int count)
        {
            OrderItem item = new OrderItem(productName, count);
            items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            items.Remove(item);
        }

    }
}
