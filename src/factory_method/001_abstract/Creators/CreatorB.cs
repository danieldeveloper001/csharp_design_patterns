using System;

namespace Project
{
    public class CreatorB : Creator
    {
        public override Product Create(
            string property1,
            int property2,
            bool property3)
        {
            return new ProductB(property1, property2, property3);
        }
    }
}