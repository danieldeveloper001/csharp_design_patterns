using System;

namespace Project
{
    public class Memento
    {
        public string Property1 { get; private set; }
        public int Property2 { get; private set; }
        public bool Property3 { get; private set; }

        public Memento(string property1, int property2, bool property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
        }
    }
}