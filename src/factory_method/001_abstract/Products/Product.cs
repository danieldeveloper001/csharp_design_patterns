using System;

namespace Project
{
    public abstract class Product
    {
        public string Property1 { get; protected set; }
        public int Property2 { get; protected set; }
        public bool Property3 { get; protected set; }

        public Product(string property1, int property2, bool property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
        }

        public abstract void Action();

    }
}