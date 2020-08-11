using System;

namespace Project
{
    public class Producer
    {
        public Factory GetFactory(string parameter)
        {
            switch(parameter)
            {
                case "A":
                    return new FactoryA();
                case "B":
                    return new FactoryB();
                case "C":
                    return new FactoryC();
                default:
                    throw new ArgumentException($"'{nameof(parameter)}' is invalid!");
            }
        }
    }
}