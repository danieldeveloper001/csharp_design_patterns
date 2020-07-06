using System;

namespace Remote
{
    public class RealService : IService
    {
        public bool Operation(string parameter)
        {
            Console.WriteLine($"{nameof(RealService)} executed with parameter '{parameter}'!");
            return true;
        }
    }
}