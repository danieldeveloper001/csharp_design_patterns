using System;

namespace Project
{
    public interface IFlyweight
    {
        string IntrinsicState { get; }

        void Operation(string extrinsicState);
    }
}