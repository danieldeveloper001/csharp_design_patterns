using System;

namespace Project
{
    public interface IMemory
    {
        string Type { get; }
        int Capacity { get; }
        string Unit { get; }
    }
}