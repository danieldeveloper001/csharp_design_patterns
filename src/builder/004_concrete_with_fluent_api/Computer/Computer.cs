using System;
using System.Collections.Generic;

namespace Project
{
    public class Computer
    {
        public Processor Processor { get; set; }
        public IList<Memory> Memory { get; set; }
        public IList<Storage> Storage { get; set; }

        public Computer(
            Processor processor,
            IList<Memory> memory,
            IList<Storage> storage)
        {
            Processor = processor;
            Memory = memory;
            Storage = storage;
        }
    }
}