using System;
using System.Collections.Generic;

namespace Project
{
    public class Waiter
    {
        private string _name;
        private IList<Order> _orders;

        public Waiter(string name)
        {
            _name = name;
            _orders = new List<Order>();
        }

        public void TakeOrderFor(Customer customer)
        {
            Console.WriteLine($"[{nameof(Waiter)}] Hello, my name is {_name} and you will be my customer today!");
            _orders.Add(customer.PlaceOrder());
        }
    }
}
