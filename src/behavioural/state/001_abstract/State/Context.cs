using System;

namespace Project
{
    public class Context
    {
        public State _state;

        public string Property1 { get => _state.Property1; }
        public int Property2 { get => _state.Property2; }
        public bool Property3 { get => _state.Property3; }

        public Context()
        {
            _state = new State1(this);
            Console.WriteLine($"> {nameof(Context)} initial state is set to {_state.GetType().Name}");
            Console.WriteLine();
        }

        public void SetState(State state)
        {
            _state = state;
            Console.WriteLine($"> {nameof(Context)} current is set to {_state.GetType().Name}");
            Console.WriteLine();
        }

        public void Handler()
        {
            Console.WriteLine($"'{nameof(Context)}.{nameof(Handler)}' action handler");
            _state.StateHandler();
        }
    }
}
