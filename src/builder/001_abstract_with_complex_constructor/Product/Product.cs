using System;

namespace Project
{
    public class Product
    {
        public string Property0 { get; private set; }
        public string Property1 { get; private set; }
        public string Property2 { get; private set; }
        public string Property3 { get; private set; }
        public string Property4 { get; private set; }
        public string Property5 { get; private set; }
        public string Property6 { get; private set; }
        public string Property7 { get; private set; }
        public string Property8 { get; private set; }
        public string Property9 { get; private set; }

        public Product(
            string property0,
            string property1,
            string property2,
            string property3,
            string property4,
            string property5,
            string property6,
            string property7,
            string property8,
            string property9)
        {
            Property0 = property0;
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
            Property4 = property4;
            Property5 = property5;
            Property6 = property6;
            Property7 = property7;
            Property8 = property8;
            Property9 = property9;
        }
    }
}