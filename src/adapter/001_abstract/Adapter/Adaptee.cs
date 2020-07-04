using System;

namespace Project
{
    public class Adaptee
    {
        public string Execute(string parameter)
        {
            return $"{nameof(Adaptee)}.{nameof(Execute)} method executed with parameter {parameter}!";
        }
    }
}