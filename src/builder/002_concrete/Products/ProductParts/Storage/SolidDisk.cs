using System;

namespace Project
{
    public class SolidDisk : IStorage
    {
        public string Type { get => nameof(SolidDisk); }

        public int Capacity { get; }
        public string Unit { get; }

        public SolidDisk(int capacity, string unit)
        {
            Capacity = capacity;
            Unit = unit;
        }
    }
}