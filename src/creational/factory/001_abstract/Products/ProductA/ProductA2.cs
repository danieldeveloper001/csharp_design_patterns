using System;

namespace Project
{
    public class ProductA2 : ProductA
    {
        public ProductA2(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductA2)}' with property value '{Property}'.");
    }
}