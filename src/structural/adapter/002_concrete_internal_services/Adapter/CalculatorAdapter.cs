using System;

namespace Project
{
    public abstract class CalculatorAdapter
    {
        protected Calculator _calculator;

        public CalculatorAdapter(Calculator calculator)
        {
            _calculator = calculator;
        }

        public abstract int Sum();
        public abstract int Sub();
    }
}
