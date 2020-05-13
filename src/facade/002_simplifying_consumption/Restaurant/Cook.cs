using System;

namespace Project
{

    public interface ICook
    {
        string Name { get; }
        void PrepareOrders();
    }

    public class Cook : ICook
    {
        public string Name { get; private set; }

        public Cook(string name)
        {
            Name = name;
        }

        public void PrepareOrders()
        {
            throw new NotImplementedException();
        }
    }
}
