using System;

namespace Project
{
    public class ProxyService : IService
    {
        private RealService _service;
        private User _user;

        public ProxyService(User user)
        {
            _service = new RealService();
            _user = user;
        }

        public bool Operation(string parameter)
        {
            if (_user.Role != UserRole.Administrator)
            {
                Console.WriteLine($"\nUnauthorized ('{_user.Name}' with role '{_user.Role}')!");
                return false;
            }

            Console.WriteLine($"\nAuthorized ('{_user.Name}' with role '{_user.Role}')!");
            return _service.Operation(parameter);
        }
    }
}