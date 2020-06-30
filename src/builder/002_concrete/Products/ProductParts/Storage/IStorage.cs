using System;

namespace Project
{
    public interface IStorage
    {
        string Type { get; }
        string Unit { get; }
        int Capacity { get; }
    }
}