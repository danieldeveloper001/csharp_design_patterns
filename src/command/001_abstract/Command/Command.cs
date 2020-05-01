using System;

namespace Project
{
    interface ICommand
    {
        void Execute();
    }

    class Command : ICommand
    {
        private IReceiver _receiver;

        public Command(IReceiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            Console.WriteLine($"{nameof(Command)} invoking {_receiver.GetType().Name}...");
            _receiver.Execute();
            Console.WriteLine($"{nameof(Command)} invoked {_receiver.GetType().Name}!");
        }
    }
}
