using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Factory();

            var firstFlyweight1 = factory.Get("flyweight1");
            firstFlyweight1.Operation($"Extrinsict State of {nameof(Flyweight1)} consumed by {nameof(firstFlyweight1)}");

            var secondFlyweight1 = factory.Get("flyweight1");
            firstFlyweight1.Operation($"Extrinsict State of {nameof(Flyweight1)} consumed by {nameof(secondFlyweight1)}");

            var thirdFlyweight1 = factory.Get("flyweight1");
            firstFlyweight1.Operation($"Extrinsict State of {nameof(Flyweight1)} consumed by {nameof(thirdFlyweight1)}");

            var firstFlyweight2 = factory.Get("flyweight2");
            firstFlyweight2.Operation($"Extrinsict State of {nameof(Flyweight2)} consumed by {nameof(firstFlyweight2)}");

            var secondFlyweight2 = factory.Get("flyweight2");
            firstFlyweight2.Operation($"Extrinsict State of {nameof(Flyweight2)} consumed by {nameof(secondFlyweight2)}");

            var thirdFlyweight2 = factory.Get("flyweight2");
            firstFlyweight2.Operation($"Extrinsict State of {nameof(Flyweight2)} consumed by {nameof(thirdFlyweight2)}");


            var firstFlyweight3 = factory.Get("flyweight3");
            firstFlyweight3.Operation($"Extrinsict State of {nameof(Flyweight3)} consumed by {nameof(firstFlyweight3)}");

            var secondFlyweight3 = factory.Get("flyweight3");
            secondFlyweight3.Operation($"Extrinsict State of {nameof(Flyweight3)} consumed by {nameof(secondFlyweight3)}");

            var thirdFlyweight3 = factory.Get("flyweight3");
            thirdFlyweight3.Operation($"Extrinsict State of {nameof(Flyweight3)} consumed by {nameof(thirdFlyweight3)}");
        }
    }
}

