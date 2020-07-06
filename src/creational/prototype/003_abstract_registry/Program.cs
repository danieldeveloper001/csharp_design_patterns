using System;

namespace Project
{
    class Program
    {
        static void Display(Prototype prototype)
        {
            Console.WriteLine($"{nameof(Prototype)}.{nameof(Prototype.Property1)}: {prototype.Property1}");
            Console.WriteLine($"{nameof(Prototype)}.{nameof(Prototype.Property2)}: {prototype.Property2}");
            Console.WriteLine($"{nameof(Prototype)}.{nameof(Prototype.Property3)}: {prototype.Property3}");
            Console.WriteLine("=====");
        }

        static void Main(string[] args)
        {
            var registry = new Registry();

            var type1 = registry.GetCopy(PrototypeType.Type1);
            Display(type1);

            var type2 = registry.GetCopy(PrototypeType.Type2);
            Display(type2);

            var type3 = registry.GetCopy(PrototypeType.Type3);
            Display(type3);
        }
    }
}
