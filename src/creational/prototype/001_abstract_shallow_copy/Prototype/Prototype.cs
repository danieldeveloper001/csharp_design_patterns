using System;

namespace Project
{
    class SubPrototype
    {
        public int Subproperty1 { get; set; }
        public string Subproperty2 { get; set; }

        public SubPrototype(int subproperty1, string subproperty2)
        {
            Subproperty1 = subproperty1;
            Subproperty2 = subproperty2;
        }
    }

    class Prototype : IPrototype
    {
        public int Property1 { get; set; }
        public string Property2 { get; set; }
        public SubPrototype Property3 { get; set; }

        public Prototype(int property1, string property2, SubPrototype property3)
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
