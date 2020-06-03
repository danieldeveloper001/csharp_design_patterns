using System;

namespace Project
{
    public class Iterator : IIterator
    {

        private IIterable _iterable;
        private int _currentIndex;
        private int _firstIndex;
        private int _lastIndex;

        public Iterator(IIterable iterable)
        {
            _iterable = iterable;
            _firstIndex = 0;
            _lastIndex = _iterable.Data.Length - 1;
        }

        public string First() =>
            _iterable.Data[_firstIndex];

        public string Previous()
        {
            if (--_currentIndex < 0)
                _currentIndex = 0;

            return _iterable.Data[_currentIndex];
        }

        public string Next()
        {
            if (++_currentIndex > _lastIndex)
                _currentIndex = _lastIndex;

            return _iterable.Data[_currentIndex];
        }

        public string Last() =>
            _iterable.Data[_lastIndex];

    }
}