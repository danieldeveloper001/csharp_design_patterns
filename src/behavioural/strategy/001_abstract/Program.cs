using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var contextWithStrategy1 = new Context(new Strategy1());
            contextWithStrategy1.Action();

            var contextWithStrategy2 = new Context(new Strategy2());
            contextWithStrategy2.Action();

            var contextWithStrategy3 = new Context(new Strategy3());
            contextWithStrategy3.Action();
        }
    }
}
