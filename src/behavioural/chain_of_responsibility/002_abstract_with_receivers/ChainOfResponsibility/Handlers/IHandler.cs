using System;

namespace Project
{
    interface IHandler<T>
    {
        void Handle(T request);
    }
}