using System;

namespace Project
{
    public class ProductB : Product
    {
        public ProductB(string property) : base(property) {}

        public override void Action() =>
            Console.WriteLine($"Executed '{nameof(Action)}' of '{nameof(ProductB)}' with property value '{Property}'.");
    }
}