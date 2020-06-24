using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();
            context.Handler();

            context.SetState(new State2(context));
            context.Handler();

            context.SetState(new State3(context));
            context.Handler();
        }
    }
}
