using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalPrototype =  new Prototype(
                1,
                "original",
                new SubPrototype(2, "original"));

            var shallowCopyPrototype = (Prototype)originalPrototype.ShallowCopy();

            // True (value comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property1)} equals " +
                $"{nameof(shallowCopyPrototype)}.{nameof(Prototype.Property1)} ? " +
                $"{originalPrototype.Property1.Equals(shallowCopyPrototype.Property1)}");

            // True (value comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property2)} equals " +
                $"{nameof(shallowCopyPrototype)}.{nameof(Prototype.Property2)} ? " +
                $"{originalPrototype.Property2.Equals(shallowCopyPrototype.Property2)}");

            // True (reference comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property3)} equals " +
                $"{nameof(shallowCopyPrototype)}.{nameof(Prototype.Property3)} ? " +
                $"{originalPrototype.Property3.Equals(shallowCopyPrototype.Property3)}");

            // Changes affect original and shallow copy
            originalPrototype.Property3.Subproperty1 = 20;
            originalPrototype.Property3.Subproperty2 = "modified";

            Console.WriteLine(
                $"{nameof(Prototype.Property3.Subproperty1)}\n" +
                $"- {nameof(originalPrototype)}: {originalPrototype.Property3.Subproperty1}\n" +
                $"- {nameof(shallowCopyPrototype)}: {shallowCopyPrototype.Property3.Subproperty1}");
            Console.WriteLine(
                $"{nameof(Prototype.Property3.Subproperty2)}\n" +
                $"- {nameof(originalPrototype)}: {originalPrototype.Property3.Subproperty2}\n" +
                $"- {nameof(shallowCopyPrototype)}: {shallowCopyPrototype.Property3.Subproperty2}");
        }
    }
}
