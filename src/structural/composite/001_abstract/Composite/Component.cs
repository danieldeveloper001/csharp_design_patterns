using System;

namespace Project
{
    abstract class Component
    {
        public string Content { get; protected set; }

        public Component(string content)
        {
            Content = content;
        }

        public abstract void Display();
    }
}
