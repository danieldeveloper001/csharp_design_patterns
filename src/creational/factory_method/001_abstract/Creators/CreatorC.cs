using System;

namespace Project
{
    public class CreatorC : Creator
    {
        public override Product Create(
            string property1,
            int property2,
            bool property3)
        {
            return new ProductC(property1, property2, property3);
        }
    }
}