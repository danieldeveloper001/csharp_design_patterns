using System;
using System.Collections.Generic;

namespace Project
{
    class Handler : IHandler<Request>
    {
        private IReceiver<Request>[] _receivers;

        public Handler(params IReceiver<Request>[] receivers)
        {
            _receivers = receivers;
        }

        public void Handle(Request request)
        {
            foreach(var receiver in _receivers)
                if (receiver.Handle(request))
                    break;
        }
    }
}