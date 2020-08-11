using System;

namespace Project
{
    public abstract class Product
    {
        public string Property { get; protected set; }

        public Product(string property)
        {
            Property = property;
        }

        public abstract void Action();
    }
}