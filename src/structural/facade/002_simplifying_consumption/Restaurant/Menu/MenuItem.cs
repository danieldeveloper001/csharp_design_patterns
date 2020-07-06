using System;

namespace Project
{
    public class MenuItem
    {
        public string Description { get; private set;}

        public MenuItem(string name)
        {
            Description = name;
        }
    }
}