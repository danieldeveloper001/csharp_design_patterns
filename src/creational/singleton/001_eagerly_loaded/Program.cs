using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.GetInstance();
            var singleton2 = Singleton.GetInstance();
            var singleton3 = Singleton.GetInstance();
            Console.WriteLine($"{nameof(singleton1)} equals to {nameof(singleton2)} = {singleton1.Equals(singleton2)}");
            Console.WriteLine($"{nameof(singleton2)} equals to {nameof(singleton3)} = {singleton2.Equals(singleton3)}");
        }
    }
}
