using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ProductBuilder();

            builder.WithProperty0("Property0");
            builder.WithProperty1("Property1");
            builder.WithProperty2("Property2");
            builder.WithProperty3("Property3");
            builder.WithProperty4("Property4");
            builder.WithProperty5("Property5");
            builder.WithProperty6("Property6");
            builder.WithProperty7("Property7");
            builder.WithProperty8("Property8");
            builder.WithProperty9("Property9");

            var product = builder.Build();

            Console.WriteLine($"> {product.GetType()}");
            Console.WriteLine($"{nameof(product.Property0)}: {product.Property0}");
            Console.WriteLine($"{nameof(product.Property1)}: {product.Property1}");
            Console.WriteLine($"{nameof(product.Property2)}: {product.Property2}");
            Console.WriteLine($"{nameof(product.Property3)}: {product.Property3}");
            Console.WriteLine($"{nameof(product.Property4)}: {product.Property4}");
            Console.WriteLine($"{nameof(product.Property5)}: {product.Property5}");
            Console.WriteLine($"{nameof(product.Property6)}: {product.Property6}");
            Console.WriteLine($"{nameof(product.Property7)}: {product.Property7}");
            Console.WriteLine($"{nameof(product.Property8)}: {product.Property8}");
            Console.WriteLine($"{nameof(product.Property9)}: {product.Property9}");
        }
    }
}
