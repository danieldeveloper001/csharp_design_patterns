using System;

namespace Project
{
    public class ProductC1 : ProductC
    {
        public ProductC1(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductC1)}' with property value '{Property}'.");
    }
}