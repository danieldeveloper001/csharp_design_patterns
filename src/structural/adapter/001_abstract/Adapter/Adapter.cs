using System;

namespace Project
{
    public class Adapter : IAdapter
    {
        private Adaptee _adaptee;
        private string _parameter;

        public Adapter(Adaptee adaptee, string parameter)
        {
            _adaptee = adaptee;
            _parameter = parameter;
        }

        public string Execute()
        {
            string result = _adaptee.Execute(_parameter);
            return result;
        }
    }
}