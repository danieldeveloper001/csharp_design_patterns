using System;

namespace Project
{
    class Handler3 : IHandler<Request>
    {
        public IHandler<Request> Next { get; set; }

        public void Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Handler3)}.{nameof(Handle)}...");
            if(String.IsNullOrEmpty(request.Property3))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Handler2)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property3)}!");
                return;
            }

            Console.WriteLine($"Unhandled by {nameof(Handler3)}.{nameof(Handle)}!");
            Next?.Handle(request);
        }
    }
}