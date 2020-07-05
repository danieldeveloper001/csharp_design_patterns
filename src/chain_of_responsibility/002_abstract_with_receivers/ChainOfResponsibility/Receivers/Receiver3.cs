using System;

namespace Project
{
    class Receiver3 : IReceiver<Request>
    {
        public bool Handle(Request request)
        {
            Console.WriteLine($"Executing {nameof(Receiver3)}.{nameof(Handle)}...");

            if(String.IsNullOrEmpty(request.Property3))
            {
                Console.WriteLine(
                    $"Handled by {nameof(Receiver3)}.{nameof(Handle)}! " +
                    $"Invalid argument {nameof(request.Property3)}!");
                return true;
            }

            Console.WriteLine($"Unhandled by {nameof(Receiver3)}.{nameof(Handle)}!");
            return false;
        }
    }
}