using System;

namespace Project
{
    class Receiver : IReceiver
    {
        public bool Execute(bool param1, int param2, string param3)
        {
            Console.WriteLine($"{nameof(Receiver)} logic executing");
            Console.WriteLine($"Param1: {param1}");
            Console.WriteLine($"Param2: {param2}");
            Console.WriteLine($"Param3: {param3}");

            return true;
        }
    }
}
