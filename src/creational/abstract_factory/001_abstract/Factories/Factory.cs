using System;

namespace Project
{
    public abstract class Factory
    {
        public abstract ProductA GetProductA(string property);
        public abstract ProductB GetProductB(string property);
        public abstract ProductC GetProductC(string property);
    }
}