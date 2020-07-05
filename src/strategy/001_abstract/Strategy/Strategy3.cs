using System;

namespace Project
{
    class Strategy3 : IStrategy
    {
        public void Action()
        {
            Console.WriteLine($"{nameof(Strategy3)}.{nameof(Action)} executed!");
        }
    }
}
