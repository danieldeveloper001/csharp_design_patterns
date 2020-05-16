using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: SOMETHING LIKE THIS BEFORE THE FACADE
            var menu = new Menu();

            var customer1 = new Customer("Kirito");
            var customer2 = new Customer("Asuna");
            var customer3 = new Customer("Shinon");

            var waiter = new Waiter("Maika");
            waiter.AddMenu(menu);
            waiter.TakeOrder(customer1);
            waiter.TakeOrder(customer2);
            waiter.TakeOrder(customer3);

            var cook = new Cook("Dino");
            waiter.SendOrdersTo(cook);
            cook.PrepareOrders();
            waiter.DeliverOrders();

            // cook.NotifyOrderReady(waiter);
            // waiter.NotifyOrderReady(customer);

            // TODO: SOMETHING LIKE THIS AFTER THE FACADE
            // var customer = new Customer();
            // var restaurant = new Restaurant();
            // restaurant.Serve(customer);

        }
    }
}
