using System;

namespace Project
{
    class Handler1 : IHandler<Request>
    {
        public IHandler<Request> Next { get; set; }

        public void Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Handler1)}.{nameof(Handle)}...");
            if(String.IsNullOrEmpty(request.Property1))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Handler1)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property1)}!");
                return;
            }

            Console.WriteLine($"Unhandled by {nameof(Handler1)}.{nameof(Handle)}!");
            Next?.Handle(request);
        }
    }
}