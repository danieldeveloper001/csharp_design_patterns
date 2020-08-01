using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n=== Undecorated Component ===");
            var undecoratedComponent = new Component();
            undecoratedComponent.Operation();

            Console.WriteLine("\n=== Decorated Component ===");
            var decoratedComponent = new Decorator(undecoratedComponent);
            decoratedComponent.Operation();
        }
    }
}
