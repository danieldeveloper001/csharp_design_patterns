using System;

namespace Project
{
    interface IPrototype
    {
        IPrototype DeepCopy();
    }
}
