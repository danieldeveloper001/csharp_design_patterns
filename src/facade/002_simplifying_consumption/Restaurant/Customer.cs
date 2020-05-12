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
            // Console.WriteLine($"[{nameof(Customer)}] Hello, my name is {Name} and here is my order!");
            throw new NotImplementedException();
        }
    }
}
