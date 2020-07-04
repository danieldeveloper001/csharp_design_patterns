using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var rootNode = new Composite("root");

            var composite1 = new Composite("composite_1");
            var leaf11 = new Leaf("leaf_1.1");
            var leaf12 = new Leaf("leaf_1.2");
            var leaf13 = new Leaf("leaf_1.3");

            var composite2 = new Composite("composite_2");
            var leaf21 = new Leaf("leaf_2.1");
            var leaf22 = new Leaf("leaf_2.2");
            var leaf23 = new Leaf("leaf_2.3");

            rootNode.Add(composite1);
            composite1.Add(leaf11);
            composite1.Add(leaf12);
            composite1.Add(leaf13);

            rootNode.Add(composite2);
            composite2.Add(leaf21);
            composite2.Add(leaf22);
            composite2.Add(leaf23);

            rootNode.Display();
        }
    }
}
