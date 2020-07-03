using System;

namespace Project
{
    public class MultiparameterCalculatorAdapter : CalculatorAdapter
    {
        private int[] _values;

        public MultiparameterCalculatorAdapter(Calculator calculator, params int[] values)
            : base(calculator)
        {
            _values = values;
        }

        public override int Sum()
        {
            int result = _values[0];

            for (int i = 1; i < _values.Length; i++)
                result = _calculator.Sum(result, _values[i]);

            return result;
        }

        public override int Sub()
        {
            int result = _values[0];

            for (int i = 1; i < _values.Length; i++)
                result = _calculator.Sub(result, _values[i]);

            return result;
        }
    }
}
