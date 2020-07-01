using System;

namespace Project
{
    public class Memory
    {
        public int Capacity { get; private set; }
        public MemoryUnit Unit { get; private set; }
        public MemoryType Type { get; private set; }

        public Memory(
            int capacity,
            MemoryUnit unit,
            MemoryType type)
        {
            Capacity = capacity;
            Unit = unit;
            Type = type;
        }
    }
}