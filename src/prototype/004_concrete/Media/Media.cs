using System;

namespace Project
{
    class Media : IMedia
    {
        public string Content { get; private set; }
        public decimal Capacity { get; private set; }
        public MediaType Type { get; private set; }
        public MediaCapacityUnit CapacityUnit { get; private set; }

        public Media(decimal capacity, MediaCapacityUnit capacityUnit, MediaType type)
        {
            Capacity = capacity;
            Type = type;
            CapacityUnit = capacityUnit;
        }

        public void Burn(string content)
        {
            Content = content;
        }

        public IMedia Clone() =>
            (IMedia)this.MemberwiseClone();

    }
}