using System;

namespace Project
{
    public abstract class Colleague
    {
        private Mediator _mediator;

        public Colleague(Mediator mediator)
        {
            _mediator = mediator;
        }

        public virtual void Send(string message)
        {
            Console.WriteLine($"[OUT][{GetType()}] {message}");
            _mediator.Send(message, this);
        }

        public virtual void Receive(string message)
        {
            Console.WriteLine($"[ IN][{GetType()}] {message}");
        }
    }
}