using System;

namespace Project
{
    public abstract class ProductA
    {
        public string Property { get; protected set; }

        public ProductA(string property)
        {
            Property = property;
        }

        public abstract void Action();
    }
}