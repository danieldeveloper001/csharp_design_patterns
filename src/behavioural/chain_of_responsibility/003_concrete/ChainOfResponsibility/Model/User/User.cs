using System;

namespace Project
{
    class User
    {
        public string Name { get; private set; }
        public UserRole Role { get; private set; }

        public User(string name, UserRole role)
        {
            Name = name;
            Role = role;
        }
    }
}