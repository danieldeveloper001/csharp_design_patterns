using System;

namespace Project
{
    interface IHandler
    {
        IHandler Next { get; set; }

        bool Handle(Request request, User user);
    }
}