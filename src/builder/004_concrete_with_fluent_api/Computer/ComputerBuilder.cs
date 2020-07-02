using System;
using System.Collections.Generic;

namespace Project
{
    public class ComputerBuilder
    {
        private Processor _processor;
        private IList<Memory> _memory;
        private IList<Storage> _storage;

        public ComputerBuilder()
        {
            _memory = new List<Memory>();
            _storage = new List<Storage>();
        }

        public ProcessorBuilder BuildProcessor()
        {
            return new ProcessorBuilder(this);
        }

        public ComputerBuilder WithProcessor(Processor processor)
        {
            _processor = processor;
            return this;
        }

        public MemoryBuilder BuildMemory()
        {
            return new MemoryBuilder(this);
        }

        public ComputerBuilder AddMemory(Memory memory)
        {
            _memory.Add(memory);
            return this;
        }

        public StorageBuilder BuildStorage()
        {
            return new StorageBuilder(this);
        }

        public ComputerBuilder AddStorage(Storage storage)
        {
            _storage.Add(storage);
            return this;
        }

        public Computer Build()
        {
            return new Computer(
                _processor,
                _memory,
                _storage);
        }


    }
}
