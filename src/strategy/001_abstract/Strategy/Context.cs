using System;

namespace Project
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void Action()
        {
            _strategy.Action();
        }
    }
}
