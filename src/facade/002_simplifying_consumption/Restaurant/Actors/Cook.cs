using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{

    public interface ICook
    {
        string Name { get; }

        Queue<IOrder> ReceivedOrders { get; }

        void PrepareOrders();
        void ReceiveOrder(IOrder order);
    }

    public class Cook : ICook
    {
        public string Name { get; private set; }

        public Queue<IOrder> ReceivedOrders { get; private set; }

        public Cook(string name)
        {
            Name = name;

            ReceivedOrders = new Queue<IOrder>();
        }

        public void PrepareOrders()
        {
            foreach(var order in ReceivedOrders.ToList())
            {
                Console.WriteLine($"\n{nameof(Cook),-10} Preparing {order.Customer.Name}'s order...");
                foreach (var item in order.Items)
                    Console.WriteLine($"{nameof(Cook),-10}   - Prepared {item.Description}");

                Console.WriteLine($"\n{nameof(Cook),-10} {order.Waiter.Name}, {order.Customer.Name}'s order is ready!");
                order.Waiter.ReadyOrder(ReceivedOrders.Dequeue());
            }
        }

        public void ReceiveOrder(IOrder order)
        {
            Console.WriteLine();
            if (ReceivedOrders.Count == 0)
                Console.WriteLine($"{nameof(Cook),-10} Hello, my name is {Name} and I will be cooking the meals today!");
            Console.WriteLine($"{nameof(Cook),-10} {order.Customer.Name}'s order will be prepared as requested, {order.Waiter.Name}!");

            order.AddCook(this);
            ReceivedOrders.Enqueue(order);
        }
    }
}
