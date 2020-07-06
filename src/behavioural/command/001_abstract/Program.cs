using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var command = new Command(receiver);
            var invoker = new Invoker(command);

            invoker.Execute();
        }
    }
}
