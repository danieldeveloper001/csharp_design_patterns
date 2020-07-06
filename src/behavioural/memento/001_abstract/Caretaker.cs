using System;
using System.Collections.Generic;

namespace Project
{
    public class Caretaker
    {
        public Stack<Memento> History { get; private set; }

        public Caretaker()
        {
            History = new Stack<Memento>();
        }

        public void Capture(Memento memento) =>
            History.Push(memento);

        public Memento Restore() =>
            History.Pop();
    }
}