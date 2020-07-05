using System;

namespace Project
{
    class Handler2 : IHandler<Request>
    {
        public IHandler<Request> Next { get; set; }

        public void Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Handler2)}.{nameof(Handle)}...");
            if(String.IsNullOrEmpty(request.Property2))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Handler2)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property2)}!");
                return;
            }

            Console.WriteLine($"Unhandled by {nameof(Handler2)}.{nameof(Handle)}!");
            Next?.Handle(request);
        }
    }
}