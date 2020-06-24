using System;

namespace Project
{
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
}

