using System;

namespace Project
{
    class Program
    {
        static void Display(IProduct product)
        {
            Console.WriteLine($"\n> {product.GetType()}");
            Console.WriteLine($"  - {product.Property1}");
            Console.WriteLine($"  - {product.Property2}");
            Console.WriteLine($"  - {product.Property3}");
        }

        static void Main(string[] args)
        {
            var director = new Director();

            var builder1 = new Builder1();
            director.Build(builder1);
            var product1 = builder1.Result();
            Display(product1);

            var builder2 = new Builder2();
            director.Build(builder2);
            var product2 = builder2.Result();
            Display(product2);

            var builder3 = new Builder3();
            director.Build(builder3);
            var product3 = builder3.Result();
            Display(product3);
        }
    }
}
