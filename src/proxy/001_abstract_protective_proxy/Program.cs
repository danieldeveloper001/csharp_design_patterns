using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var administrator = new User() { Role = UserRole.Administrator };
            var user = new User() { Role = UserRole.User };

            var realService = new RealService();
            var proxyServiceWithUser = new ProxyService(realService, user);
            var proxyServiceWithAdministrator = new ProxyService(realService, administrator);

            var clientWithRealService = new Client(realService);
            clientWithRealService.Operation($"{nameof(clientWithRealService)}");

            var clientWithProxyServiceAndWithAdministrator = new Client(proxyServiceWithAdministrator);
            clientWithProxyServiceAndWithAdministrator.Operation($"{nameof(clientWithProxyServiceAndWithAdministrator)}");

            var clientWithProxyServiceWithUserService = new Client(proxyServiceWithUser);
            clientWithProxyServiceWithUserService.Operation($"{nameof(clientWithProxyServiceWithUserService)}");
        }
    }
}
