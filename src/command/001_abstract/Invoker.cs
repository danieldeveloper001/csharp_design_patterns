using System;
using System.Collections.Generic;

namespace Project
{
    class Invoker
    {
        private IList<ICommand> _commands;

        public Invoker(IList<ICommand> commands)
        {
            foreach(var command in commands)
                Console.WriteLine($"{nameof(Invoker)} encapsulating {commands.GetType().Name}");

            _commands = commands;
        }

        public bool Execute(bool param1, int param2, string param3)
        {
            var result = true;
            foreach(var command in _commands)
            {
                Console.WriteLine($"{nameof(Invoker)} invoking {command.GetType().Name}");
                result &= command.Execute(param1, param2, param3);
            }

            return result;
        }
    }
}
