using System;

namespace Project
{
    class Sender
    {
        public void Execute(Request request)
        {
            var handler = new Handler(
                new Receiver1(),
                new Receiver2(),
                new Receiver3()
            );

            handler.Handle(request);
        }
    }
}