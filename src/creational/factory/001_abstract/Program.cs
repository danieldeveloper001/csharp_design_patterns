using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var producer = new Producer();

            var factoryA = producer.GetFactory("A");
            var productA = factoryA.GetProduct("ValueA");
            productA.Action();

            var factoryB = producer.GetFactory("B");
            var productB = factoryB.GetProduct("ValueB");
            productB.Action();

            var factoryC = producer.GetFactory("C");
            var productC = factoryC.GetProduct("ValueC");
            productC.Action();
        }
    }
}
