using System;

namespace Project
{
    public class Factory2 : Factory
    {
        public override ProductA GetProductA(string property) =>
            new ProductA2(property);

        public override ProductB GetProductB(string property) =>
            new ProductB2(property);

        public override ProductC GetProductC(string property) =>
            new ProductC2(property);
    }
}