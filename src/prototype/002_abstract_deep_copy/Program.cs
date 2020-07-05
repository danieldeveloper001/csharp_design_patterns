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

            var deepCopyPrototype = (Prototype)originalPrototype.DeepCopy();

            // True (value comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property1)} equals" +
                $"{nameof(deepCopyPrototype)}.{nameof(Prototype.Property1)} ? " +
                $"{originalPrototype.Property1.Equals(deepCopyPrototype.Property1)}");

            // True (value comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property2)} equals " +
                $"{nameof(deepCopyPrototype)}.{nameof(Prototype.Property2)} ? " +
                $"{originalPrototype.Property2.Equals(deepCopyPrototype.Property2)}");

            // False (reference comparison)
            Console.WriteLine(
                $"{nameof(originalPrototype)}.{nameof(Prototype.Property3)} equals " +
                $"{nameof(deepCopyPrototype)}.{nameof(Prototype.Property3)} ? " +
                $"{originalPrototype.Property3.Equals(deepCopyPrototype.Property3)}");

            // Changes affect just original
            originalPrototype.Property3.Subproperty1 = 20;
            originalPrototype.Property3.Subproperty2 = "modified";

            Console.WriteLine(
                $"{nameof(Prototype.Property3.Subproperty1)}\n" +
                $"- {nameof(originalPrototype)}: {originalPrototype.Property3.Subproperty1}\n" +
                $"- {nameof(deepCopyPrototype)}: {deepCopyPrototype.Property3.Subproperty1}\n");
            Console.WriteLine(
                $"{nameof(Prototype.Property3.Subproperty2)}\n" +
                $"- {nameof(originalPrototype)}: {originalPrototype.Property3.Subproperty2}\n" +
                $"- {nameof(deepCopyPrototype)}: {deepCopyPrototype.Property3.Subproperty2}\n");
        }
    }
}
