using System;

namespace Project
{
    public class ProductC : Product
    {
        public ProductC(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductC)}' with property value '{Property}'.");
    }
}