using System;
using System.Collections.Generic;

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
            throw new NotImplementedException();
        }

        public void ReceiveOrder(IOrder order)
        {
            if (ReceivedOrders.Count == 0)
                Console.WriteLine($"\n{nameof(Cook),-10} Hello, my name is {Name} and I will be cooking the meals today!");
            Console.WriteLine($"\n{nameof(Cook),-10} {order.Customer.Name}'s order will be prepared as requested, {order.Waiter.Name}!");

            order.AddCook(this);
            ReceivedOrders.Enqueue(order);
        }
    }
}
