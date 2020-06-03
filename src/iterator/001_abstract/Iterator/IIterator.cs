using System;

namespace Project
{
    public interface IIterator
    {
        bool HasNext();
        string First();
        string Last();
        string Previous();
        string Next();
    }
}