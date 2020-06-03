using System;

namespace Project
{

    public class Iterable : IIterable
    {
        public string[] Data { get; private set; }

        public Iterable(int capacity)
        {
            Data = new string[capacity];
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }

}