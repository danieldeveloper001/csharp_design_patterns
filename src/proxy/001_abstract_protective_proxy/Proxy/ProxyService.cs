using System;

namespace Project
{
    public class ProxyService : IService
    {
        private RealService _service;
        private User _user;

        public ProxyService(RealService service, User user)
        {
            _service = service;
            _user = user;
        }

        public bool Operation(string parameter)
        {
            if (_user.Role != UserRole.Administrator)
                return false;

            return _service.Operation(parameter);
        }
    }
}