using System;

namespace Project
{
    public class Flyweight3 : IFlyweight
    {
        public string IntrinsicState { get; private set; }

        public Flyweight3()
        {
            IntrinsicState = $"Intrinsic State of {nameof(Flyweight3)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight3)}");
            Console.WriteLine($"- Intrinsic State: {IntrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}