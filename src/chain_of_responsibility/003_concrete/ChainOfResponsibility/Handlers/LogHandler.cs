using System;

namespace Project
{
    class LogHandler : IHandler
    {
        public IHandler Next { get; set; }

        public bool Handle(Request request, User user)
        {
            Console.WriteLine($"\nProcessing request...");

            var result = Next.Handle(request, user);

            Console.WriteLine($"Request processed with {(result ? "SUCCESS" : "ERROR")}!");

            return result;
        }
    }
}