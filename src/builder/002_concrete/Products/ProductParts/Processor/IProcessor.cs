using System;

namespace Project
{
    public interface IProcessor
    {
        string Name { get; }
        decimal Clock { get; set; }
        decimal Cache { get; set; }
    }
}