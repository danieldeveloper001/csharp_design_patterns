using System;

namespace Project
{
    public class Director
    {
        public void Build(IBuilder builder)
        {
            builder.BuildStep1();
            builder.BuildStep2();
            builder.BuildStep3();
        }
    }
}