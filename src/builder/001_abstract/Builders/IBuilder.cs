using System;

namespace Project
{
    public interface IBuilder
    {
        void BuildStep1();
        void BuildStep2();
        void BuildStep3();

        IProduct Result();
    }
}
