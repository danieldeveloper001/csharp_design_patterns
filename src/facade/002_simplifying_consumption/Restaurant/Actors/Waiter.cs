using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{

    public interface IWaiter
    {
        string Name { get; }

        Menu Menu { get; }
        Queue<IOrder> TakenOrders { get; }
        Queue<IOrder> ReadyOrders { get; }

        void TakeOrder(ICustomer customer);
        void SendOrdersTo(ICook cook);
    }

    public class Waiter : IWaiter
    {
        public string Name { get; private set; }

        public Menu Menu { get; private set; }
        public Queue<IOrder> TakenOrders { get; private set; }
        public Queue<IOrder> ReadyOrders { get; private set; }

        public Waiter(string name)
        {
            Name = name;
            TakenOrders = new Queue<IOrder>();
        }

        public void AddMenu(Menu menu)
        {
            if (!(Menu is null))
                return;

            Menu = menu;
        }

        public void TakeOrder(ICustomer customer)
        {
            Console.WriteLine($"\n{nameof(Waiter),-10} Hello, my name is {Name} and you will be my customer today!");

            //TODO: CONSIDER WHO SHOULD BE RESPONSIBLE FOR CREATING THE ORDER. WHO OWNS IT?
            // - THE CUSTOMER 'ISSUES' AN ORDER
            // - THE CUSTOMER 'TAKES' AN ORDER
            var order = customer.PlaceOrder(Menu);

            order.AddWaiter(this);
            TakenOrders.Enqueue(order);
        }

        public void SendOrdersTo(ICook cook)
        {
            Console.WriteLine($"\n{nameof(Waiter),-10} Hello, {cook.Name}! I have some orders for you!");
            foreach(var order in TakenOrders.ToList())
            {
                Console.WriteLine($"\n{nameof(Waiter),-10} - Customer {order.Customer.Name} wants...");
                foreach (var item in order.Items)
                    Console.WriteLine($"{nameof(Waiter),-10}   - {item.Description}");

                cook.ReceiveOrder(order);
                TakenOrders.Dequeue();
            }
        }
    }
}
