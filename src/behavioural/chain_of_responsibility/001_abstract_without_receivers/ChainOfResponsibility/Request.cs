using System;

namespace Project
{
    class Request
    {
        public string Property1 { get; private set; }
        public string Property2 { get; private set; }
        public string Property3 { get; private set; }

        public Request(
            string property1,
            string property2,
            string property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
        }
    }
}