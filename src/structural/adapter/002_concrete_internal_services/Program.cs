using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] valuesToBeOperated = new int[] {1, 2, 3, 4, 5};

            CalculatorAdapter calculator = new MultiparameterCalculatorAdapter(
                new Calculator(),
                valuesToBeOperated);

            int sum = calculator.Sum();
            Console.WriteLine($"{nameof(sum)}: {sum}");

            int sub = calculator.Sub();
            Console.WriteLine($"{nameof(sub)}: {sub}");
        }
    }
}
