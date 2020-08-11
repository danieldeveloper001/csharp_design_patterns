using System;

namespace Project
{
    public class FactoryA : Factory
    {
        public override Product GetProduct(string property) =>
            new ProductA(property);
    }
}