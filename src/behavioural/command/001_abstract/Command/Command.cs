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
            Console.WriteLine($"'{nameof(Command)}' calling '{_receiver.GetType().Name}'...");
            _receiver.Execute();
            Console.WriteLine($"'{nameof(Command)}' called '{_receiver.GetType().Name}'!");
        }
    }
}
