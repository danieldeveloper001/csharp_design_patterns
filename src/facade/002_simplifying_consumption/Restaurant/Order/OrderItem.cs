using System;

namespace Project
{
    public interface IOrderItem
    {
        string Name { get; }
        double Amount { get; }
        OrderItemUnit Unit { get; }
    }

    public class OrderItem : IOrderItem
    {
        public string Name { get; private set; }
        public double Amount { get; private set; }
        public OrderItemUnit Unit { get; private set; }

        public OrderItem(string name, double amount, OrderItemUnit unit)
        {
            Name = name;
            Amount = amount;
            Unit = unit;
        }
    }
}
