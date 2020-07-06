using System;

namespace Project
{
    public interface IIterator
    {
        bool HasPrevious();
        bool HasNext();

        string First();
        string Last();
        string Previous();
        string Next();
    }
}