using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var administrator = new User("administrator", UserRole.Administrator);
            var user = new User("user", UserRole.User);

            var request = new Request(RequestAction.Write, "file");

            var pipeline = new RequestPipeline();
            pipeline.Process(request, administrator);
            pipeline.Process(request, user);
        }
    }
}
