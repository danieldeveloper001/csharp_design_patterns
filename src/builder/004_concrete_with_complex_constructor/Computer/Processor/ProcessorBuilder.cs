using System;

namespace Project
{
    public class ProcessorBuilder
    {
        private ComputerBuilder _computerBuilder;

        private string _name;
        private decimal _clock;
        private decimal _cache;

        public ProcessorBuilder(ComputerBuilder computerBuilder)
        {
            _computerBuilder = computerBuilder;
        }

        public ProcessorBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ProcessorBuilder WithClock(decimal clock)
        {
            _clock = clock;
            return this;
        }

        public ProcessorBuilder WithCache(decimal cache)
        {
            _cache = cache;
            return this;
        }

        public ComputerBuilder Add()
        {
            _computerBuilder.WithProcessor(
                new Processor(_name, _clock, _cache));

            return _computerBuilder;
        }
    }
}
