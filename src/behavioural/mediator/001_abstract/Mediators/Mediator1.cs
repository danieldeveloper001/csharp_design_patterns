using System;
using System.Collections.Generic;
using System.Linq;

namespace Project
{
    public class Mediator1 : Mediator
    {
        public Colleague1 Colleague1 { get; set; }
        public Colleague2 Colleague2 { get; set; }
        public Colleague3 Colleague3 { get; set; }

        public Mediator1() {}

        public override void Send(string message, Colleague colleague)
        {
            if (colleague is Colleague1)
            {
                Colleague2.Receive(message);
                Colleague3.Receive(message);
                return;
            }

            if (colleague is Colleague2)
            {
                Colleague1.Receive(message);
                Colleague3.Receive(message);
                return;
            }

            if (colleague is Colleague3)
            {
                Colleague1.Receive(message);
                Colleague2.Receive(message);
                return;
            }
        }
    }
}