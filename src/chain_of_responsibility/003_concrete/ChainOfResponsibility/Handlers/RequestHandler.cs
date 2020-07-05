using System;

namespace Project
{
    class RequestHandler : IHandler
    {
        public IHandler Next { get; set; }

        public bool Handle(Request request, User user)
        {
            if(request.Action == RequestAction.Write)
                Console.WriteLine($"Writing resource {request.Resource}...");
            else if (request.Action == RequestAction.Read)
                Console.WriteLine($"Reading resource {request.Resource}...");
            else
                return false;

            return true;
        }
    }
}