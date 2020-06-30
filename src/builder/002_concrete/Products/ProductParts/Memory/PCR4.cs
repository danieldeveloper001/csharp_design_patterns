using System;

namespace Project
{
    public class PCR4 : IMemory
    {
        public string Type { get => nameof(PCR4); }

        public int Capacity { get; }
        public string Unit { get; }

        public PCR4(int capacity, string unit)
        {
            Capacity = capacity;
            Unit = unit;
        }
    }
}