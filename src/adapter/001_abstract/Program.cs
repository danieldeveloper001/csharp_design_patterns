using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            var adapteeResult = adaptee.Execute("parameter");
            Console.WriteLine($"{nameof(adapteeResult)}: {adapteeResult}");

            IAdapter adapter = new Adapter(new Adaptee(), "parameter");
            var adapterResult = adapter.Execute();
            Console.WriteLine($"{nameof(adapterResult)}: {adapterResult}");
        }
    }
}
