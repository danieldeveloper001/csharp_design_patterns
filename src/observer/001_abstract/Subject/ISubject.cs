using System;
using System.Collections.Generic;

namespace Project
{
    public interface ISubject
    {
        List<IObserver> Observers { get; }
        string Property1 { get; }
        int Property2 { get; }
        bool Property3 { get; }

        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();
        void Update(string property1, int property2, bool property3);

    }
}