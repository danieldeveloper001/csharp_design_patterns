using System;

namespace Project
{

    public interface ICustomer
    {
        string Name { get; }

        Order PlaceOrder();
    }

    public class Customer : ICustomer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        public Order PlaceOrder()
        {
            // TODO: JUST FOR FUN CREATE RANDOM ORDER
            Console.WriteLine($"[{nameof(Customer)}] Hello, my name is {Name} and here is my order!");

            var order = new Order(this);

            order.AddItem(PlaceOrderItem("item1", 1d, OrderItemUnit.Unit1));
            order.AddItem(PlaceOrderItem("item2", 1d, OrderItemUnit.Unit2));
            order.AddItem(PlaceOrderItem("item3", 1d, OrderItemUnit.Unit3));

            return order;
        }

        private OrderItem PlaceOrderItem(string name, double amount, OrderItemUnit unit)
        {
            Console.WriteLine($"[{nameof(Customer)}] - I want {name} {amount} of {unit}.");
            return new OrderItem(name, amount, unit);
        }
    }
}
