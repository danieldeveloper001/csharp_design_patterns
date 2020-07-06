using System;

namespace Project
{
    public class Flyweight1 : IFlyweight
    {
        public string IntrinsicState { get; private set; }

        public Flyweight1()
        {
            IntrinsicState = $"Intrinsic State of {nameof(Flyweight1)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight1)}");
            Console.WriteLine($"- Intrinsic State: {IntrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}