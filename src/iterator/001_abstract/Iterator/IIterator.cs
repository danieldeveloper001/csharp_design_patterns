using System;

namespace Project
{
    public interface IIterator
    {
        string First();
        string Previous();
        string Next();
        string Last();
    }
}