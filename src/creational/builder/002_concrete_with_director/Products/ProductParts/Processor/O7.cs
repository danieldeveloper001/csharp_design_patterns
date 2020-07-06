using System;

namespace Project
{
    public class O7 : IProcessor
    {
        public string Name { get => nameof(O7); }
        public decimal Clock { get; set; }
        public decimal Cache { get; set; }
    }
}