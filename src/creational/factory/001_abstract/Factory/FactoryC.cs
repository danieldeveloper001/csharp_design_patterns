using System;

namespace Project
{
    public class FactoryC : Factory
    {
        public override Product GetProduct(string property) =>
            new ProductC(property);
    }
}