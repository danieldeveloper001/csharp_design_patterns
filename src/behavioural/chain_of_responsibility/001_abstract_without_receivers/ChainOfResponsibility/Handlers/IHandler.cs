using System;

namespace Project
{
    interface IHandler<T>
    {
        IHandler<T> Next { get; set; }

        void Handle(T request);
    }
}