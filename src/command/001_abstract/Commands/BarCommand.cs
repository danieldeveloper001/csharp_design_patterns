using System;

namespace Project
{
    class BarCommand : ICommand
    {
        private IReceiver _receiver;

        public BarCommand(IReceiver receiver)
        {
            Console.WriteLine($"{nameof(BarCommand)} encapsulating {receiver.GetType().Name}");
            _receiver = receiver;
        }

        public bool Execute(bool param1, int param2, string param3)
        {
            Console.WriteLine($"{nameof(BarCommand)} invoking {_receiver.GetType().Name}");
            return _receiver.Execute(param1, param2, param3);
        }
    }
}
