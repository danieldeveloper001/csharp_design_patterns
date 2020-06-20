using System;

namespace Project
{
    public class Flyweight2 : IFlyweight
    {
        public string IntrinsicState { get; private set; }

        public Flyweight2()
        {
            IntrinsicState = $"Intrinsic State of {nameof(Flyweight2)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight2)}");
            Console.WriteLine($"- Intrinsic State: {IntrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}