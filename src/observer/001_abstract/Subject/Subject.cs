using System;
using System.Collections.Generic;

namespace Project
{
    public class Subject : ISubject
    {
        public List<IObserver> Observers { get; private set; }
        public string Property1 { get; private set; }
        public int Property2 { get; private set; }
        public bool Property3 { get; private set; }

        public Subject()
        {
            Observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine($"{nameof(Observer)} attached!");
        }

        public void Detach(IObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine($"{nameof(Observer)} detached!");
        }

        public void Notify()
        {
            foreach (var observer in Observers)
                observer.Update(Property1, Property2, Property3);
        }

        public void Update(string property1, int property2, bool property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
            Console.WriteLine($"{nameof(Subject)} state updated to '{Property1}', '{Property2}' and '{Property3}'!");
        }
    }
}