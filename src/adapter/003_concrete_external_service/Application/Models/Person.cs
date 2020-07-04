using System;

namespace Project
{
    public class Person : IPerson
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
