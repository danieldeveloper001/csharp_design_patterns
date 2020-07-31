using System;

namespace Project
{
    public class Decorator : IComponent
    {
        private IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }

        public void Operation()
        {
            Console.WriteLine($"{nameof(Decorator)} executing before {_component.GetType().Name}");
            _component.Operation();
            Console.WriteLine($"{nameof(Decorator)} executing after {_component.GetType().Name}");
        }
    }
}