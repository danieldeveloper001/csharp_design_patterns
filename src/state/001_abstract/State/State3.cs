using System;

namespace Project
{
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

