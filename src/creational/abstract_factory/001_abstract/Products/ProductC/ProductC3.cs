using System;

namespace Project
{
    public class ProductC3 : ProductC
    {
        public ProductC3(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductC3)}' with property value '{Property}'.");
    }
}