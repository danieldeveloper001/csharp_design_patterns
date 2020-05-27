using System;
using System.Collections.Generic;

namespace Project
{
    public class Caretaker
    {
        public Stack<Memento> Mementos { get; private set; }

        public Caretaker()
        {
            Mementos = new Stack<Memento>();
        }

        public void Capture(Memento memento) =>
            Mementos.Push(memento);

        public Memento Restore() =>
            Mementos.Pop();
    }
}