using System;
using System.Collections.Generic;

namespace Project
{
    public interface IOrder
    {
        IList<MenuItem> Items { get; }

        ICook Cook { get; }
        ICustomer Customer { get; }
        IWaiter Waiter { get; }

        void AddCook(ICook cook);
        void AddCustomer(ICustomer customer);
        void AddWaiter(IWaiter waiter);

    }

    public class Order : IOrder
    {
        public IList<MenuItem> Items { get; private set;}

        public ICook Cook { get; private set; }
        public ICustomer Customer { get; private set;}
        public IWaiter Waiter { get; private set;}

        public Order()
        {
            Items = new List<MenuItem>();
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
        }

        public void AddCook(ICook cook)
        {
            if (!(Cook is null))
                return;

            Cook = cook;
        }

        public void AddCustomer(ICustomer customer)
        {
            if (!(Customer is null))
                return;

            Customer = customer;
        }

        public void AddWaiter(IWaiter waiter)
        {
            if (!(Waiter is null))
                return;

            Waiter = waiter;
        }
    }
}
