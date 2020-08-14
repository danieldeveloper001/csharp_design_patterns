using System;

namespace Project
{
    public class ProductA1 : ProductA
    {
        public ProductA1(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductA1)}' with property value '{Property}'.");
    }
}