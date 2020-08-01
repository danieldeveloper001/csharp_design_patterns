using System;

namespace Project
{
    public class Component : IComponent
    {
        public void Operation()
        {
            Console.WriteLine($"{nameof(Component)} executing {nameof(Operation)}");
        }
    }
}