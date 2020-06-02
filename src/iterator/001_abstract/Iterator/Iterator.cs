using System;

namespace Project
{
    public class Iterator : IIterator
    {

        private IIterable _iterable;

        public Iterator(IIterable iterable)
        {
            _iterable = iterable;
        }

        public string First() { return String.Empty; }
        public string Previous() { return String.Empty; }
        public string Next() { return String.Empty; }
        public string Last() { return String.Empty; }
    }
}