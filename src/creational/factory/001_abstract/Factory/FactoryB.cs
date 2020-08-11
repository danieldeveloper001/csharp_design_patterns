using System;

namespace Project
{
    public class FactoryB : Factory
    {
        public override Product GetProduct(string property) =>
            new ProductB(property);
    }
}