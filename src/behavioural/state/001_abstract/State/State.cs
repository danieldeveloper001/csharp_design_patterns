using System;

namespace Project
{
    public abstract class State
    {
        protected Context _context;

        public string Property1 { get; protected set; }
        public int Property2 { get; protected set; }
        public bool Property3 { get; protected set; }

        public State(Context context)
        {
            _context = context;
        }

        public void StateHandler()
        {
            Console.WriteLine($"'{nameof(State)}.{nameof(StateHandler)}' action handler");
            StateSpecificHandler();
            Console.WriteLine($"- {nameof(Property1)}: {Property1}");
            Console.WriteLine($"- {nameof(Property2)}: {Property2}");
            Console.WriteLine($"- {nameof(Property3)}: {Property3}");
            Console.WriteLine();
        }

        protected abstract void StateSpecificHandler();
    }
}