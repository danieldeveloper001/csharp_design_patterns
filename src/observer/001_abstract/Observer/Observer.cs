using System;

namespace Project
{
    public class Observer : IObserver
    {
        public string Property1 { get; private set; }
        public int Property2 { get; private set; }
        public bool Property3 { get; private set; }

        public void Update(string property1, int property2, bool property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
            Console.WriteLine($"{nameof(Observer)} state updated to '{Property1}', '{Property2}' and '{Property3}'!");
        }
    }
}