using System;
using System.Collections.Generic;

namespace Project
{
    public class LowEndComputerBuilder : IComputerBuilder
    {
        private IComputer _computer;

        public LowEndComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetupProcessor()
        {
            _computer.Processor = new O7();
        }

        public void SetupMemory()
        {
            _computer.Memory = new List<IMemory>();
            _computer.Memory.Add(new PCR4(capacity: 4, unit: "GB"));
            _computer.Memory.Add(new PCR4(capacity: 4, unit: "GB"));
        }

        public void SetupStorage()
        {
            _computer.Storage = new List<IStorage>();
            _computer.Storage.Add(new SolidDisk(capacity: 128, unit: "GB"));
            _computer.Storage.Add(new HardDisk(capacity: 1, unit: "TB"));
        }

        public IComputer Result()
        {
            return _computer;
        }
    }
}