using System;
using System.Collections.Generic;

namespace Project
{

    public interface ICustomer
    {
        string Name { get; }

        Order PlaceOrder(Menu menu);
        void ReceiveOrder(IOrder order);
    }

    public class Customer : ICustomer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            Name = name;
        }

        public Order PlaceOrder(Menu menu)
        {
            MenuItem PlaceOrderFor(IList<MenuItem> menuItems)
            {
                var randomItemIndex = new Random().Next(menuItems.Count);
                var randomItem = menuItems[randomItemIndex];

                Console.WriteLine($"{nameof(Customer),-10} - {randomItem.Description}.");
                return randomItem;
            }

            Console.WriteLine($"\n{nameof(Customer),-10} Hello, my name is {Name} and here is my order!");

            var order = new Order();
            order.AddCustomer(this);
            order.AddItem(PlaceOrderFor(menu.Drinks));
            order.AddItem(PlaceOrderFor(menu.Meals));
            order.AddItem(PlaceOrderFor(menu.Deserts));

            return order;
        }

        public void ReceiveOrder(IOrder order)
        {
            Console.WriteLine($"\n{nameof(Customer),-10} {order.Waiter.Name}, thank you very much! Itadakimasu!");
        }
    }
}
