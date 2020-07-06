using System;

namespace Project
{
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
}