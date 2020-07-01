using System;
using System.Collections.Generic;

namespace Project
{
    public class MidEndComputerBuilder : IComputerBuilder
    {
        private IComputer _computer;

        public MidEndComputerBuilder()
        {
            _computer = new Computer();
        }

        public void SetupProcessor()
        {
            _computer.Processor = new O5();
        }

        public void SetupMemory()
        {
            _computer.Memory = new List<IMemory>();
            _computer.Memory.Add(new PCR4(capacity: 8, unit: "GB"));
            _computer.Memory.Add(new PCR4(capacity: 8, unit: "GB"));
        }

        public void SetupStorage()
        {
            _computer.Storage = new List<IStorage>();
            _computer.Storage.Add(new SolidDisk(capacity: 256, unit: "GB"));
            _computer.Storage.Add(new HardDisk(capacity: 2, unit: "TB"));
        }

        public IComputer Result()
        {
            return _computer;
        }
    }
}