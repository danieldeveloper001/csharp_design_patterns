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
            Console.WriteLine(
                $"Capturing state with values '{Property1}', '{Property2}' and '{Property3}'");
            return new Memento(Property1, Property2, Property3);
        }

        public void Restore(Memento memento)
        {
            Console.WriteLine(
                $"Restoring state with values '{memento.Property1}', '{memento.Property2}' and '{memento.Property3}'");
            Property1 = memento.Property1;
            Property2 = memento.Property2;
            Property3 = memento.Property3;
        }
    }
}