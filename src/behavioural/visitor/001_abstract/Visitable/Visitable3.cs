using System;

namespace Project
{
    public class Visitable3 : IVisitable
    {
        public string Property { get; }

        public Visitable3(string property)
        {
            Property = property;
        }

        public void Accept(IVisitor visitor)
        {
            Console.WriteLine($"\nExecuting {nameof(Accept)} method of {nameof(Visitable3)}");
            visitor.Visit3(this);
        }
    }
}
