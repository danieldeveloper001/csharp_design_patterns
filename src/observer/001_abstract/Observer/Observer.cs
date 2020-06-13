using System;

namespace Project
{
    public class Observer : IObserver
    {
        public ISubject Subject { get; private set; }
        public string Property1 { get; private set; }
        public int Property2 { get; private set; }
        public bool Property3 { get; private set; }

        public Observer(ISubject subject)
        {
            Subject = subject;
        }

        public void Update()
        {
            Property1 = Subject.Property1;
            Property2 = Subject.Property2;
            Property3 = Subject.Property3;
            Console.WriteLine($"{nameof(Observer)} state updated to '{Property1}', '{Property2}' and '{Property3}'!");
        }
    }
}