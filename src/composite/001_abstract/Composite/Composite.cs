using System;
using System.Collections.Generic;

namespace Project
{
    class Composite : Component
    {
        private IList<Component> _children;

        public Composite(string content) : base(content)
        {
            _children = new List<Component>();
        }

        public void Add(Component component) =>
            _children.Add(component);

        public void Remove(Component component) =>
            _children.Remove(component);

        public override void Display()
        {
            Console.WriteLine($"{nameof(Content)}: {Content}");
            foreach(var child in _children)
                child.Display();
        }
    }
}
