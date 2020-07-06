using System;

namespace Project
{
    public class ProxyService : IService
    {
        private RealService _service;

        public ProxyService()
        {
            _service = new RealService();
        }

        public bool Operation(string parameter)
        {
            Console.WriteLine($"{nameof(ProxyService)} executed action before invoking the service!");
            var result = _service.Operation(parameter);
            Console.WriteLine($"{nameof(ProxyService)} executed action after invoking the service!");

            return result;
        }
    }
}