using System;
using System.Collections.Generic;

namespace Project
{
    public interface IOrder
    {
        ICustomer Customer { get; }

        IList<IOrderItem> Items { get; }
    }

    public class Order : IOrder
    {
        public ICustomer Customer { get; private set;}
        public IList<IOrderItem> Items { get; private set;}

        public Order(ICustomer customer)
        {
            Customer = customer;
            Items = new List<IOrderItem>();
        }

        public void AddItem(IOrderItem item)
        {
            Items.Add(item);
        }
    }
}
