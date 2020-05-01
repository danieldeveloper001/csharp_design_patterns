using System;

namespace Project
{
    class BazCommand : ICommand
    {
        private IReceiver _receiver;

        public BazCommand(IReceiver receiver)
        {
            Console.WriteLine($"{nameof(BazCommand)} encapsulating {receiver.GetType().Name}");
            _receiver = receiver;
        }

        public bool Execute(bool param1, int param2, string param3)
        {
            Console.WriteLine($"{nameof(BazCommand)} invoking {_receiver.GetType().Name}");
            return _receiver.Execute(param1, param2, param3);
        }
    }
}
