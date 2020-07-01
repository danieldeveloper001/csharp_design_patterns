using System;

namespace Project
{
    public class MemoryBuilder
    {
        private ComputerBuilder _computerBuilder;

        private int _capacity;
        private MemoryUnit _unit;
        private MemoryType _type;

        public MemoryBuilder(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public MemoryBuilder WithCapacity(int capacity, MemoryUnit unit)
        {
            _capacity = capacity;
            _unit = unit;
            return this;
        }

        public MemoryBuilder WithType(MemoryType type)
        {
            _type = type;
            return this;
        }

        public ComputerBuilder Add()
        {
            _computerBuilder.AddMemory(
                new Memory(_capacity, _unit, _type));

            return _computerBuilder;
        }
    }
}
