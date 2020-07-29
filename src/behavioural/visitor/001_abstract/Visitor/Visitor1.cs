using System;

namespace Project
{
    public class Visitor1 : IVisitor
    {
        public void Visit1(Visitable1 visitable1)
        {
            Console.WriteLine($"Executing {nameof(Visit1)} method of {nameof(Visitor1)}");
        }

        public void Visit2(Visitable2 visitable2)
        {
            Console.WriteLine($"Executing {nameof(Visit2)} method of {nameof(Visitor1)}");
        }

        public void Visit3(Visitable3 visitable3)
        {
            Console.WriteLine($"Executing {nameof(Visit3)} method of {nameof(Visitor1)}");
        }
    }
}
