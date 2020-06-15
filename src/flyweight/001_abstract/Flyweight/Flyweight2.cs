using System;

namespace Project
{
    public class Flyweight2 : IFlyweight
    {
        private string _intrinsicState;
        public string IntrinsicState { get { return _intrinsicState; } }

        public Flyweight2()
        {
            _intrinsicState = $"Intrinsic State of {nameof(Flyweight2)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight2)}");
            Console.WriteLine($"- Intrinsic State: {_intrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}