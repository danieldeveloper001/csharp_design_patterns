using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();

            var commands = new List<ICommand>
            {
                new FooCommand(receiver),
                new BarCommand(receiver),
                new BazCommand(receiver)
            };

            var invoker = new Invoker(commands);

            invoker.Execute(true, 123, "xpto");
        }
    }
}
