using System;

namespace Project
{
    public class Storage
    {
        public int Capacity { get; private set; }
        public StorageUnit Unit { get; private set; }
        public StorageType Type { get; private set; }

        public Storage(
            int capacity,
            StorageUnit unit,
            StorageType type)
        {
            Capacity = capacity;
            Unit = unit;
            Type = type;
        }
    }
}