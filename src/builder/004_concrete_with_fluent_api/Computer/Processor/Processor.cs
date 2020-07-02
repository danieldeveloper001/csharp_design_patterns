using System;

namespace Project
{
    public class Processor
    {
        public string Name { get; private set; }
        public decimal Clock { get; private set; }
        public decimal Cache { get; private set; }

        public Processor(
            string name,
            decimal clock,
            decimal cache)
        {
            Name = name;
            Clock = clock;
            Cache = cache;
        }
    }
}