using System;

namespace Project
{
    public class Flyweight1 : IFlyweight
    {
        private string _intrinsicState;
        public string IntrinsicState { get { return _intrinsicState; } }

        public Flyweight1()
        {
            _intrinsicState = $"Intrinsic State of {nameof(Flyweight1)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight1)}");
            Console.WriteLine($"- Intrinsic State: {_intrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}