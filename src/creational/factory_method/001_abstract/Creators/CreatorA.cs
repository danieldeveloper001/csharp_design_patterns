using System;

namespace Project
{
    public class CreatorA : Creator
    {
        public override Product Create(
            string property1,
            int property2,
            bool property3)
        {
            return new ProductA(property1, property2, property3);
        }
    }
}