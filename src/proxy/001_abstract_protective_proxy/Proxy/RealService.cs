using System;

namespace Project
{
    public class RealService : IService
    {
        public bool Operation(string parameter)
        {
            Console.WriteLine(parameter);
            return true;
        }
    }
}