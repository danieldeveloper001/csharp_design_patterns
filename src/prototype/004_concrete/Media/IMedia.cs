using System;

namespace Project
{
    interface IMedia
    {
        void Burn(string content);
        IMedia Clone();
    }
}