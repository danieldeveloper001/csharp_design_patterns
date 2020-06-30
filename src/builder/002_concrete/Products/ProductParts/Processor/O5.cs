using System;

namespace Project
{
    public class O5 : IProcessor
    {
        public string Name { get => nameof(O5); }
        public decimal Clock { get; set; }
        public decimal Cache { get; set; }
    }
}