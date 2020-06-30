using System;

namespace Project
{
    public class Builder3 : IBuilder
    {
        private IProduct _product;

        public Builder3()
        {
            _product = new Product();
        }

        public void BuildStep1()
        {
            _product.Property1 = $"{nameof(Builder3)}.{nameof(BuildStep1)}";
        }

        public void BuildStep2()
        {
            _product.Property2 = $"{nameof(Builder3)}.{nameof(BuildStep2)}";
        }

        public void BuildStep3()
        {
            _product.Property3 = $"{nameof(Builder3)}.{nameof(BuildStep3)}";
        }

        public IProduct Result()
        {
            return _product;
        }
    }
}