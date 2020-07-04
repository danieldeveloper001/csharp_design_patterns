using System;

namespace Project
{
    class Leaf : Component
    {
        public Leaf(string content) : base(content) {}

        public override void Display()
        {
            Console.WriteLine($"{nameof(Content)}: {Content}");
        }
    }
}
