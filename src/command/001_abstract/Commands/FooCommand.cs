using System;

namespace Project
{
    class FooCommand : ICommand
    {
        private IReceiver _receiver;

        public FooCommand(IReceiver receiver)
        {
            Console.WriteLine($"{nameof(FooCommand)} encapsulating {receiver.GetType().Name}");
            _receiver = receiver;
        }

        public bool Execute(bool param1, int param2, string param3)
        {
            Console.WriteLine($"{nameof(FooCommand)} invoking {_receiver.GetType().Name}");
            return _receiver.Execute(param1, param2, param3);
        }
    }
}
