using System;
using Remote;

namespace Local
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
            return _service.Operation(parameter);
        }
    }
}