using System;

namespace Project
{
    public class O3 : IProcessor
    {
        public string Name { get => nameof(O3); }
        public decimal Clock { get; set; }
        public decimal Cache { get; set; }
    }
}