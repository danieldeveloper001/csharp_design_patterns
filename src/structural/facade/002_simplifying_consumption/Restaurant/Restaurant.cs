using System;
using System.Collections.Generic;

namespace Project
{
    public interface IRestaurant
    {
        Menu Menu { get; }
        IList<ICook> Cooks { get; }
        IList<IWaiter> Waiters { get; }

        void Serve(ICustomer customer);
    }

    public class Restaurant : IRestaurant
    {
        public Menu Menu { get; private set; }
        public IList<ICook> Cooks { get; private set; }
        public IList<IWaiter> Waiters { get; private set; }

        public Restaurant()
        {
            Cooks = new List<ICook>();
            Waiters = new List<IWaiter>();
        }

        public void AddMenu(Menu menu) => Menu = Menu ?? menu;
        public void AddCook(ICook cook) => Cooks.Add(cook);
        public void AddWaiter(IWaiter waiter) => Waiters.Add(waiter);

        public void Serve(ICustomer customer)
        {
            var randomCook = new Random().Next(Cooks.Count);
            var cook = Cooks[randomCook];

            var randomWaiter = new Random().Next(Waiters.Count);
            var waiter = Waiters[randomWaiter];

            waiter.TakeOrder(customer, Menu);
            waiter.SendOrdersTo(cook);

            cook.PrepareOrders();
            waiter.DeliverOrders();
        }
    }
}
