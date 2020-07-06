using System;

namespace Project
{
    interface IReceiver<T>
    {
        bool Handle(T request);
    }
}