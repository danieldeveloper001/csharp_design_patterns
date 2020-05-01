using System;

namespace Project
{
    interface IReceiver
    {
        void Execute();
    }

    class Receiver : IReceiver
    {
        public void Execute()
        {
            Console.WriteLine($"{nameof(Receiver)} executed!");
        }
    }
}
