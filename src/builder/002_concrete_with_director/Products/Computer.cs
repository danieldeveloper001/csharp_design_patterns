using System;
using System.Collections.Generic;

namespace Project
{
    public class Computer : IComputer
    {
        public IProcessor Processor { get; set; }
        public IList<IMemory> Memory { get; set; }
        public IList<IStorage> Storage { get; set; }
    }
}