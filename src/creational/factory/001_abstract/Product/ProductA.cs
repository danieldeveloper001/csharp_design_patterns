using System;

namespace Project
{
    public class ProductA : Product
    {
        public ProductA(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductA)}' with property value '{Property}'.");
    }
}