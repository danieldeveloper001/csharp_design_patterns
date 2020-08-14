using System;

namespace Project
{
    public class ProductB2 : ProductB
    {
        public ProductB2(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductB2)}' with property value '{Property}'.");
    }
}