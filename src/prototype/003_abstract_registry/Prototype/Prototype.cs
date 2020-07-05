using System;

namespace Project
{
    class Prototype : IPrototype
    {
        public string Property1 { get; set; }
        public string Property2 { get; set; }
        public string Property3 { get; set; }

        public Prototype(string property1, string property2, string property3)
        {
            Property1 = property1;
            Property2 = property2;
            Property3 = property3;
        }

        public IPrototype ShallowCopy()
        {
            return (IPrototype)this.MemberwiseClone();
        }
    }
}
