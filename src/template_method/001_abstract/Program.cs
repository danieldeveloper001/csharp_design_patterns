using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteClass1 = new ConcreteClass1();
            concreteClass1.Operation();

            var concreteClass2 = new ConcreteClass2();
            concreteClass2.Operation();
        }
    }
}
