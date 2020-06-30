using System;

namespace Project
{
    public class Director
    {
        public void Build(IComputerBuilder builder)
        {
            builder.SetupProcessor();
            builder.SetupMemory();
            builder.SetupStorage();
            builder.SetupStorage();
        }
    }
}