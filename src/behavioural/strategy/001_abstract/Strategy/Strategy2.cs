using System;

namespace Project
{
    class Strategy2 : IStrategy
    {
        public void Action()
        {
            Console.WriteLine($"{nameof(Strategy2)}.{nameof(Action)} executed!");
        }
    }
}
