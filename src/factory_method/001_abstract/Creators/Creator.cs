using System;

namespace Project
{
    public abstract class Creator
    {
        public abstract Product Create(
            string property1,
            int property2,
            bool property3);
    }
}