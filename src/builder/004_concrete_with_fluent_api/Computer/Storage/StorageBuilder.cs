using System;

namespace Project
{
    public class StorageBuilder
    {
        private ComputerBuilder _computerBuilder;

        private int _capacity;
        private StorageUnit _unit;
        private StorageType _type;

        public StorageBuilder(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public StorageBuilder WithCapacity(int capacity, StorageUnit unit)
        {
            _capacity = capacity;
            _unit = unit;
            return this;
        }

        public StorageBuilder WithType(StorageType type)
        {
            _type = type;
            return this;
        }

        public ComputerBuilder Add()
        {
            _computerBuilder.AddStorage(
                new Storage(_capacity, _unit, _type));

            return _computerBuilder;
        }
    }
}
