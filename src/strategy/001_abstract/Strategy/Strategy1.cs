using System;

namespace Project
{
    class Strategy1 : IStrategy
    {
        public void Action()
        {
            Console.WriteLine($"{nameof(Strategy1)}.{nameof(Action)} executed!");
        }
    }
}
