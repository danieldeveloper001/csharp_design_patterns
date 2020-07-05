using System;

namespace Project
{
    class Sender
    {
        public void Execute(Request request)
        {
            var handler1 = new Handler1();
            var handler2 = new Handler2();
            var handler3 = new Handler3();

            handler1.Next = handler2;
            handler2.Next = handler3;

            handler1.Handle(request);
        }
    }
}