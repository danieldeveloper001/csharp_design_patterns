using System;

namespace Project
{
    public class Originator
    {
        public string Property1 { get; set; }
        public int Property2 { get; set; }
        public bool Property3 { get; set; }

        public Originator() {}

        public Memento Capture()
        {
            return new Memento(Property1, Property2, Property3);
        }

        public void Restore(Memento memento)
        {
            Property1 = memento.Property1;
            Property2 = memento.Property2;
            Property3 = memento.Property3;
        }
    }
}