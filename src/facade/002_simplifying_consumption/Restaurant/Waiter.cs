using System;
using System.Collections.Generic;

namespace Project
{

    public interface IWaiter
    {
        string Name { get; }
        IList<Order> TakenOrders { get; }

        void TakeOrderFrom(ICustomer customer);
        void SendOrdersTo(ICook cook);
    }

    public class Waiter : IWaiter
    {
        public string Name { get; private set; }
        public IList<Order> TakenOrders { get; private set; } // TODO: QUEUE
        public IList<Order> ReadyOrders { get; private set; } // TODO: QUEUE

        public Waiter(string name)
        {
            Name = name;
            TakenOrders = new List<Order>();
        }

        public void TakeOrderFrom(ICustomer customer)
        {
            Console.WriteLine($"[{nameof(Waiter)}] Hello, my name is {Name} and you will be my customer today!");
            TakenOrders.Add(customer.PlaceOrder());
        }

        public void SendOrdersTo(ICook cook)
        {
            Console.WriteLine($"[{nameof(Waiter)}] Hello, {cook.Name}! I have some orders for you!");
            foreach(var order in TakenOrders)
            {
                Console.WriteLine($"[{nameof(Waiter)}] - Customer {order.Customer.Name} wants...");
                foreach (var item in order.Items)
                    Console.WriteLine($"[{nameof(Waiter)}]   - {item.Amount} {item.Unit} of {item.Name}");

                // cook.PrepareOrder(order);
            }
        }
    }
}
