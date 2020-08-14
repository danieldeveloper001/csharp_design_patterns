using System;

namespace Project
{
    public class ProductC2 : ProductC
    {
        public ProductC2(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductC2)}' with property value '{Property}'.");
    }
}