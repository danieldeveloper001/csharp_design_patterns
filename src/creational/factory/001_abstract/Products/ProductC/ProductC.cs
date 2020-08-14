using System;

namespace Project
{
    public abstract class ProductC
    {
        public string Property { get; protected set; }

        public ProductC(string property)
        {
            Property = property;
        }

        public abstract void Action();
    }
}