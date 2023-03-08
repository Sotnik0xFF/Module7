using System;


namespace Module7.OrderAggregate
{
    public class OrderItem
    {
        private readonly Product product;
        private int count;

        public OrderItem(string productName, int count)
        {
            product = new Product(productName);
            Count = count;
        }

        public Product Product
        {
            get => product;
        }
        public int Count
        {
            get => count;
            set => count = value < 0 ? 0 : value;
        }
    }
}
