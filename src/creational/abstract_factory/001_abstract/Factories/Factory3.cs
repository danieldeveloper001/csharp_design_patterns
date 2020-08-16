using System;

namespace Project
{
    public class Factory3 : Factory
    {
        public override ProductA GetProductA(string property) =>
            new ProductA3(property);

        public override ProductB GetProductB(string property) =>
            new ProductB3(property);

        public override ProductC GetProductC(string property) =>
            new ProductC3(property);
    }
}