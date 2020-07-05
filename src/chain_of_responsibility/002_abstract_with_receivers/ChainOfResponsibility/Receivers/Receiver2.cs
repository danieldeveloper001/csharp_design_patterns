using System;

namespace Project
{
    class Receiver2 : IReceiver<Request>
    {
        public bool Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Receiver2)}.{nameof(Handle)}...");

            if(String.IsNullOrEmpty(request.Property2))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Receiver2)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property2)}!");
                return true;
            }

            Console.WriteLine($"Unhandled by {nameof(Receiver2)}.{nameof(Handle)}!");
            return false;
        }
    }
}