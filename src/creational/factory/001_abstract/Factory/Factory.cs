using System;

namespace Project
{
    public abstract class Factory
    {
        public abstract Product GetProduct(string property);
    }
}