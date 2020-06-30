using System;
using System.Collections.Generic;

namespace Project
{
    public interface IComputer
    {
        IProcessor Processor { get; set; }
        IList<IMemory> Memory { get; set; }
        IList<IStorage> Storage { get; set; }
    }
}