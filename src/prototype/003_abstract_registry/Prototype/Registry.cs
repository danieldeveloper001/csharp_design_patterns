using System;
using System.Collections.Generic;

namespace Project
{
    class Registry
    {
        Dictionary<PrototypeType, Prototype> _prototypes;

        public Registry()
        {
            _prototypes = new Dictionary<PrototypeType, Prototype>();

            _prototypes.Add(PrototypeType.Type1, new Prototype(
                "Type1.Property1",
                "Type1.Property2",
                "Type1.Property3"));

            _prototypes.Add(PrototypeType.Type2, new Prototype(
                "Type2.Property1",
                "Type2.Property2",
                "Type2.Property3"));

            _prototypes.Add(PrototypeType.Type3, new Prototype(
                "Type3.Property1",
                "Type3.Property2",
                "Type3.Property3"));
        }

        public Prototype GetCopy(PrototypeType type) =>
            (Prototype)_prototypes[type].ShallowCopy();
    }
}
