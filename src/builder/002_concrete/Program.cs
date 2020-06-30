using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var director = new Director();

            var builder1 = new LowEndComputerBuilder();
            director.Build(builder1);
            var product1 = builder1.Result();
            Display(product1);

            var builder2 = new MidEndComputerBuilder();
            director.Build(builder2);
            var product2 = builder2.Result();
            Display(product2);

            var builder3 = new HighEndComputerBuilder();
            director.Build(builder3);
            var product3 = builder3.Result();
            Display(product3);
        }

        static void Display(IComputer computer)
        {
            Console.WriteLine($"\n> {computer.GetType().Name}");

            Console.WriteLine($"  - Processor");
            Console.WriteLine($"    - {computer.Processor.Name}");

            Console.WriteLine($"  - Memory");
            foreach(var item in computer.Memory)
                Console.WriteLine($"    - {item.Capacity}{item.Unit} {item.Type}");

            Console.WriteLine($"  - Storage");
            foreach(var item in computer.Storage)
                Console.WriteLine($"    - {item.Capacity}{item.Unit} {item.Type}");
        }
    }
}
