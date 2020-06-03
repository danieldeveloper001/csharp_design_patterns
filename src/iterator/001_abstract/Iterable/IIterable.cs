using System;

namespace Project
{

    public interface IIterable
    {
        string[] Data { get; }

        IIterator GetIterator();
        void SetData(string[] data);
    }

}