using System;

namespace Project
{
    public class ProductB3 : ProductB
    {
        public ProductB3(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductB3)}' with property value '{Property}'.");
    }
}