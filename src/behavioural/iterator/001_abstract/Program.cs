using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var iterable = new Iterable(
                new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });

            var iterator = iterable.GetIterator();
            Console.WriteLine($"First Item: {iterator.First()}");
            Console.WriteLine($"Last Item: {iterator.Last()}");

            while(iterator.HasNext())
                Console.WriteLine($"> {iterator.Next()}");

            while(iterator.HasPrevious())
                Console.WriteLine($"< {iterator.Previous()}");

            while(iterator.HasNext())
                Console.WriteLine($"> {iterator.Next()}");
        }
    }
}
