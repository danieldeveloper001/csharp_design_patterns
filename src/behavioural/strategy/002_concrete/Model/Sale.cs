using System;

namespace Project
{
    class Sale
    {
        public int Amount { get; private set; }
        public decimal Price { get; private set; }
        public string Product { get; private set; }

        public Sale(string product, decimal price, int amount)
        {
            Product = product;
            Price = price;
            Amount = amount;
        }
    }
}
