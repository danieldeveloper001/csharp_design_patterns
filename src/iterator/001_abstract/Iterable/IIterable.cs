using System;

namespace Project
{
    public interface IIterable
    {
        int Count();
        string GetByIndex(int index);
        IIterator GetIterator();
    }
}