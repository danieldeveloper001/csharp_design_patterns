using System;

namespace Project
{
    public interface IVisitor
    {
        void Visit(Potion item);
        void Visit(Shield item);
        void Visit(Sword item);
    }
}