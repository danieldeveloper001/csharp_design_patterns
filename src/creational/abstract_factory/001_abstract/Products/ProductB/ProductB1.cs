using System;

namespace Project
{
    public class ProductB1 : ProductB
    {
        public ProductB1(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductB1)}' with property value '{Property}'.");
    }
}