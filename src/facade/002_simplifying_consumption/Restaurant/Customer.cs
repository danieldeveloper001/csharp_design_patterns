using System;

namespace Project
{
    public class Customer
    {
        private string _name;

        public Customer(string name)
        {
            _name = name;
        }

        public Order PlaceOrder()
        {
            // Console.WriteLine($"[{nameof(Customer)}] Hello, my name is {_name} and here is my order!");
            throw new NotImplementedException();
        }
    }
}
