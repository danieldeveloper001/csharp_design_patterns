using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{

    public interface IWaiter
    {
        string Name { get; }

        Queue<IOrder> TakenOrders { get; }
        Queue<IOrder> ReadyOrders { get; }

        void DeliverOrders();
        void ReadyOrder(IOrder order);
        void SendOrdersTo(ICook cook);
        void TakeOrder(ICustomer customer, Menu menu);
    }

    public class Waiter : IWaiter
    {
        public string Name { get; private set; }

        public Queue<IOrder> TakenOrders { get; private set; }
        public Queue<IOrder> ReadyOrders { get; private set; }

        public Waiter(string name)
        {
            Name = name;
            TakenOrders = new Queue<IOrder>();
            ReadyOrders = new Queue<IOrder>();
        }

        public void DeliverOrders()
        {
            foreach(var order in ReadyOrders.ToList())
            {
                Console.WriteLine($"\n{nameof(Waiter),-10} {order.Customer.Name}, thank you very much for your patience, here is your order! Bon Apetit!");
                order.Customer.ReceiveOrder(ReadyOrders.Dequeue());
            }
        }
        public void ReadyOrder(IOrder order)
        {
            Console.WriteLine($"\n{nameof(Waiter),-10} Thank you very much, {order.Cook.Name}!");
            ReadyOrders.Enqueue(order);
        }

        public void SendOrdersTo(ICook cook)
        {
            Console.WriteLine($"\n{nameof(Waiter),-10} Hello, {cook.Name}! I have some orders for you!");
            foreach(var order in TakenOrders.ToList())
            {
                Console.WriteLine($"\n{nameof(Waiter),-10} - Customer {order.Customer.Name} wants...");
                foreach (var item in order.Items)
                    Console.WriteLine($"{nameof(Waiter),-10}   - {item.Description}");

                cook.ReceiveOrder(TakenOrders.Dequeue());
            }
            Console.WriteLine($"\n{nameof(Waiter),-10} Thank you very much, {cook.Name}! Ganbatte!");
        }

        public void TakeOrder(ICustomer customer, Menu menu)
        {
            Console.WriteLine($"\n{nameof(Waiter),-10} Hello, my name is {Name} and you will be my customer today!");

            //TODO: CONSIDER WHO SHOULD BE RESPONSIBLE FOR CREATING THE ORDER. WHO OWNS IT?
            // - THE CUSTOMER 'ISSUES' AN ORDER
            // - THE CUSTOMER 'TAKES' AN ORDER
            var order = customer.PlaceOrder(menu);

            order.AddWaiter(this);
            TakenOrders.Enqueue(order);
        }

    }
}
