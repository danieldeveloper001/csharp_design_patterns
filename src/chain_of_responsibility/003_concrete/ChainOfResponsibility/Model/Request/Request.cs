using System;

namespace Project
{
    class Request
    {
        public RequestAction Action { get; private set; }
        public string Resource { get; private set; }

        public Request(RequestAction action, string resource)
        {
            Action = action;
            Resource = resource;
        }
    }
}