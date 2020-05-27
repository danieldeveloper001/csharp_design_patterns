using System;

namespace Project
{
    public class ProductA : Product
    {
        public ProductA(string property1, int property2, bool property3)
            : base(property1, property2, property3) {}

        public override void Action()
        {
            Console.WriteLine($"'{nameof(ProductA)}' instance, with values '{Property1}', '{Property2}' and '{Property3}'");
        }
    }
}