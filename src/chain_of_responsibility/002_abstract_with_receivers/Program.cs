using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var sender = new Sender();

            Console.WriteLine("\n===== HANDLING REQUEST =====");
            sender.Execute(new Request("value1", "value2", "value3"));

            Console.WriteLine("\n===== HANDLING REQUEST =====");
            sender.Execute(new Request("value1", "value2", null));

            Console.WriteLine("\n===== HANDLING REQUEST =====");
            sender.Execute(new Request("value1", null, null));

            Console.WriteLine("\n===== HANDLING REQUEST =====");
            sender.Execute(new Request(null, null, null));
        }
    }
}
