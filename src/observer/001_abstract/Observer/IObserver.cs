using System;

namespace Project
{
    public interface IObserver
    {
        ISubject Subject { get; }

        string Property1 { get; }
        int Property2 { get; }
        bool Property3 { get; }

        void Update();
    }
}