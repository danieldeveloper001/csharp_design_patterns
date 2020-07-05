using System;

namespace Project
{
    class Receiver1 : IReceiver<Request>
    {
        public bool Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Receiver1)}.{nameof(Handle)}...");

            if(String.IsNullOrEmpty(request.Property1))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Receiver1)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property1)}!");
                return true;
            }

            Console.WriteLine($"Unhandled by {nameof(Receiver1)}.{nameof(Handle)}!");
            return false;
        }
    }
}