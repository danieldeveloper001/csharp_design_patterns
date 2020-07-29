using System;

namespace Project
{
    public class Visitable1 : IVisitable
    {
        public string Property { get; }

        public Visitable1(string property)
        {
            Property = property;
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"\nExecuting {nameof(Accept)} method of {nameof(Visitable1)}");
            visitor.Visit1(this);
        }
    }
}
