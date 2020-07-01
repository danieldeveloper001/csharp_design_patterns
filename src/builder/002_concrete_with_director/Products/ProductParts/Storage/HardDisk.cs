using System;

namespace Project
{
    public class HardDisk : IStorage
    {
        public string Type { get => nameof(HardDisk); }

        public int Capacity { get; }
        public string Unit { get; }

        public HardDisk(int capacity, string unit)
        {
            Capacity = capacity;
            Unit = unit;
        }
    }
}