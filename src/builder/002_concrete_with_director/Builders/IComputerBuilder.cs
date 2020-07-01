using System;

namespace Project
{
    public interface IComputerBuilder
    {
        void SetupProcessor();
        void SetupMemory();
        void SetupStorage();

        IComputer Result();
    }
}
