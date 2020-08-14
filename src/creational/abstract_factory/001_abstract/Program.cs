using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = new Factory1();

            var productA1 = factory1.GetProductA("value");
            productA1.Action();

            var productB1 = factory1.GetProductB("value");
            productB1.Action();

            var productC1 = factory1.GetProductC("value");
            productC1.Action();

            var factory2 = new Factory2();

            var productA2 = factory2.GetProductA("value");
            productA2.Action();

            var productB2 = factory2.GetProductB("value");
            productB2.Action();

            var productC2 = factory2.GetProductC("value");
            productC2.Action();

            var factory3 = new Factory3();

            var productA3 = factory3.GetProductA("value");
            productA3.Action();

            var productB3 = factory3.GetProductB("value");
            productB3.Action();

            var productC3 = factory3.GetProductC("value");
            productC3.Action();
        }
    }
}
