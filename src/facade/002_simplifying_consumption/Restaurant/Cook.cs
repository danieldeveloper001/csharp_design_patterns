using System;

namespace Project
{

    public interface ICook
    {
        string Name { get; }
        void PrepareOrder();
    }

    public class Cook : ICook
    {
        public string Name { get; private set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void PrepareOrder()
        {
            throw new NotImplementedException();
        }
    }
}
