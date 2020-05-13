using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: SOMETHING LIKE THIS BEFORE THE FACADE
            var customer1 = new Customer("Kirito");
            var customer2 = new Customer("Asuna");
            var customer3 = new Customer("Shinon");

            var waiter = new Waiter("Maika");
            waiter.TakeOrderFrom(customer1);
            waiter.TakeOrderFrom(customer2);
            waiter.TakeOrderFrom(customer3);

            var cook = new Cook("Dino");
            waiter.SendOrdersTo(cook);

            // cook.PrepareOrders();

            // cook.NotifyOrderReady(waiter);
            // waiter.NotifyOrderReady(customer);

            // TODO: SOMETHING LIKE THIS AFTER THE FACADE
            // var customer = new Customer();
            // var restaurant = new Restaurant();
            // restaurant.Serve(customer);

        }
    }
}
