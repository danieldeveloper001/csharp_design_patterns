using System;

namespace Project
{
    class Sale : ReportComponent
    {
        private string _product;
        private decimal _value;
        private int _amount;

        public Sale(string product, decimal value, int amount)
        {
            _product = product;
            _value = value;
            _amount = amount;
        }

        public override void Display()
        {
            Console.WriteLine($"{_product,-20}{_value,10}");
        }
    }
}
