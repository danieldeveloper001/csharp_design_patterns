using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new List<Product>();

            products.Add(new CreatorA().Create($"Created by {nameof(CreatorA)}", 1, true));
            products.Add(new CreatorB().Create($"Created by {nameof(CreatorB)}", 2, false));
            products.Add(new CreatorC().Create($"Created by {nameof(CreatorC)}", 3, true));

            products.ForEach((p) => p.Action());
        }
    }
}
