using System;

namespace Project
{
    public class ProductBuilder
    {

        private string _property0;
        private string _property1;
        private string _property2;
        private string _property3;
        private string _property4;
        private string _property5;
        private string _property6;
        private string _property7;
        private string _property8;
        private string _property9;

        public ProductBuilder() {}

        public ProductBuilder WithProperty0(string property0)
        {
            _property0 = property0;
            return this;
        }

        public ProductBuilder WithProperty1(string property1)
        {
            _property1 = property1;
            return this;
        }

        public ProductBuilder WithProperty2(string property2)
        {
            _property2 = property2;
            return this;
        }

        public ProductBuilder WithProperty3(string property3)
        {
            _property3 = property3;
            return this;
        }

        public ProductBuilder WithProperty4(string property4)
        {
            _property4 = property4;
            return this;
        }

        public ProductBuilder WithProperty5(string property5)
        {
            _property5 = property5;
            return this;
        }

        public ProductBuilder WithProperty6(string property6)
        {
            _property6 = property6;
            return this;
        }

        public ProductBuilder WithProperty7(string property7)
        {
            _property7 = property7;
            return this;
        }

        public ProductBuilder WithProperty8(string property8)
        {
            _property8 = property8;
            return this;
        }

        public ProductBuilder WithProperty9(string property9)
        {
            _property9 = property9;
            return this;
        }

        public Product Build()
        {
            return new Product(
                _property0,
                _property1,
                _property2,
                _property3,
                _property4,
                _property5,
                _property6,
                _property7,
                _property8,
                _property9);
        }
    }
}