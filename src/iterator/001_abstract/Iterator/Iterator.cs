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
            _currentIndex = -1;
            _firstIndex = 0;
            _lastIndex = _iterable.Count() - 1;
        }

        public bool HasPrevious() =>
            _currentIndex != _firstIndex;

        public bool HasNext() =>
            _currentIndex != _lastIndex;

        public string First() =>
            _iterable.GetByIndex(_firstIndex);

        public string Last() =>
            _iterable.GetByIndex(_lastIndex);

        public string Previous()
        {
            if (--_currentIndex < 0)
                _currentIndex = 0;

            return _iterable.GetByIndex(_currentIndex);
        }

        public string Next()
        {
            if (++_currentIndex > _lastIndex)
                _currentIndex = _lastIndex;

            return _iterable.GetByIndex(_currentIndex);
        }
    }
}