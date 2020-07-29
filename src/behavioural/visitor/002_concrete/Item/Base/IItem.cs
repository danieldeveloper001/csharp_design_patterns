using System;

namespace Project
{
    public interface IItem
    {
        void Accept(IVisitor visitor);
    }
}