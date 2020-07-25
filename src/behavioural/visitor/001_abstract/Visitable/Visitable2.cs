using System;

namespace Project
{
    public class Visitable2 : IVisitable
    {
        public string Property { get; }

        public Visitable2(string property)
        {
            Property = property;
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"\nExecuting {nameof(Accept)} method of {nameof(Visitable2)}");
            visitor.Visit2(this);
        }
    }
}
