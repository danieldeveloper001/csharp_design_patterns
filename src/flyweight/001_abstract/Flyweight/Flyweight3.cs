using System;

namespace Project
{
    public class Flyweight3 : IFlyweight
    {
        private string _intrinsicState;
        public string IntrinsicState { get { return _intrinsicState; } }

        public Flyweight3()
        {
            _intrinsicState = $"Intrinsic State of {nameof(Flyweight3)}";
        }

        public void Operation(string extrinsicState)
        {
            Console.WriteLine($"{nameof(Flyweight3)}");
            Console.WriteLine($"- Intrinsic State: {_intrinsicState}");
            Console.WriteLine($"- Extrinsic State: {extrinsicState}");
        }
    }
}