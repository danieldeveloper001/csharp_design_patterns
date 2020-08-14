using System;

namespace Project
{
    public class Factory1 : Factory
    {
        public override ProductA GetProductA(string property) =>
            new ProductA1(property);

        public override ProductB GetProductB(string property) =>
            new ProductB1(property);

        public override ProductC GetProductC(string property) =>
            new ProductC1(property);
    }
}