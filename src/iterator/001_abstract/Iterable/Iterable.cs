using System;

namespace Project
{

    public class Iterable : IIterable
    {
        private string[] _data;

        public Iterable(int capacity)
        {
            _data = new string[capacity];
        }

        public IIterator GetIterator()
        {
            return new Iterator(this);
        }
    }

}