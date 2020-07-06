using System;

namespace Project
{
    public class ProductC : Product
    {
        public ProductC(string property1, int property2, bool property3)
            : base(property1, property2, property3) {}

        public override void Action()
        {
            Console.WriteLine($"'{nameof(ProductC)}' instance, with values '{Property1}', '{Property2}' and '{Property3}'");
        }
    }
}