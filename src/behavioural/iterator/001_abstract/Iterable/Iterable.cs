using System;

namespace Project
{

    public class Iterable : IIterable
    {
        private string[] _data;

        public Iterable(string[] data)
        {
            _data = data;
        }

        public int Count() =>
            _data.Length;

        public string GetByIndex(int index) =>
            _data[index];

        public IIterator GetIterator() =>
            new Iterator(this);
    }
}