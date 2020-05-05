using System;
using System.Collections.Generic;

namespace Project
{
    class Invoker
    {
        private ICommand _command;

        public Invoker(ICommand command)
        {
            _command = command;
        }

        public void Execute()
        {
            Console.WriteLine($"'{nameof(Invoker)}' calling '{_command.GetType().Name}'...");
            _command.Execute();
            Console.WriteLine($"'{nameof(Invoker)}' called '{_command.GetType().Name}'!");
        }
    }
}
