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

    public class State1 : State
    {
        public State1(Context context) : base(context)
        {
            Property1 = "State 1";
            Property2 = 1;
            Property3 = true;
        }

        protected override void StateSpecificHandler() =>
            Console.WriteLine($"'{nameof(State1)}.{nameof(StateSpecificHandler)}' action handler");
    }

    public class State2 : State
    {
        public State2(Context context) : base(context)
        {
            Property1 = "State 2";
            Property2 = 2;
            Property3 = false;
        }

        protected override void StateSpecificHandler() =>
            Console.WriteLine($"'{nameof(State2)}.{nameof(StateSpecificHandler)}' action handler");
    }

    public class State3 : State
    {
        public State3(Context context) : base(context)
        {
            Property1 = "State 3";
            Property2 = 3;
            Property3 = true;
        }

        protected override void StateSpecificHandler() =>
            Console.WriteLine($"'{nameof(State3)}.{nameof(StateSpecificHandler)}' action handler");
    }
}

