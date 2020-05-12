﻿using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: SOMETHING LIKE THIS BEFORE THE FACADE
            var customer1 = new Customer("");
            var customer2 = new Customer("");
            var customer3 = new Customer("");

            var waiter = new Waiter("");
            waiter.TakeOrderFrom(customer1);
            waiter.TakeOrderFrom(customer2);
            waiter.TakeOrderFrom(customer3);

            var cook = new Cook("");
            waiter.SendOrdersTo(cook);

            cook.PrepareOrder();
            // cook.NotifyOrderReady(waiter);
            // waiter.NotifyOrderReady(customer);

            // TODO: SOMETHING LIKE THIS AFTER THE FACADE
            // var customer = new Customer();
            // var restaurant = new Restaurant();
            // restaurant.Serve(customer);

        }
    }
}
