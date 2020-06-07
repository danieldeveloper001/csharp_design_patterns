using System;

namespace Project
{
    public interface IObserver
    {
        string Property1 { get; }
        int Property2 { get; }
        bool Property3 { get; }

        void Update(string property1, int property2, bool property3);
    }
}