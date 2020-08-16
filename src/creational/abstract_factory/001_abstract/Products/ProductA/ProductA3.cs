using System;

namespace Project
{
    public class ProductA3 : ProductA
    {
        public ProductA3(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductA3)}' with property value '{Property}'.");
    }
}