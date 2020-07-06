using System;
using System.Linq;

namespace Project
{
    class AuthorizationHandler : IHandler
    {
        public IHandler Next { get; set; }

        public bool Handle(Request request, User user)
        {
            if (user.Role != UserRole.Administrator)
            {
                Console.WriteLine($"Unauthorized, must have role {nameof(UserRole.Administrator)}!");
                return false;
            }

            return Next.Handle(request, user);
        }
    }
}