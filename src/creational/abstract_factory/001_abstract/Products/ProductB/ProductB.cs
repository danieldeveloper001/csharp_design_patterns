using System;

namespace Project
{
    public abstract class ProductB
    {
        public string Property { get; protected set; }

        public ProductB(string property)
        {
            Property = property;
        }

        public abstract void Action();
    }
}