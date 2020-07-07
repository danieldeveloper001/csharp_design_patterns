using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new Mediator1();

            var colleague1 = new Colleague1(mediator);
            var colleague2 = new Colleague2(mediator);
            var colleague3 = new Colleague3(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;
            mediator.Colleague3 = colleague3;

            colleague1.Send($"Hello, my name is {nameof(colleague1)}!");
            Console.WriteLine();

            colleague2.Send($"Hello, my name is {nameof(colleague2)}!");
            Console.WriteLine();

            colleague3.Send($"Hello, my name is {nameof(colleague3)}!");
            Console.WriteLine();
        }
    }
}
