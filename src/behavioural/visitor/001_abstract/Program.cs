using System;
using System.Collections.Generic;

namespace Project
{

    class Program
    {
        static void Main(string[] args)
        {
            var visitables = new List<IVisitable>()
            {
                new Visitable1("value"),
                new Visitable2("value"),
                new Visitable3("value"),
            };

            var visitor1 = new Visitor1();
            var visitor2 = new Visitor2();
            var visitor3 = new Visitor3();

            visitables.ForEach(x => x.Accept(visitor1));
            visitables.ForEach(x => x.Accept(visitor2));
            visitables.ForEach(x => x.Accept(visitor3));
        }
    }
}
