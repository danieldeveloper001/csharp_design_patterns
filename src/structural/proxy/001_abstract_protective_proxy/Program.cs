using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientWithAdministratorUser = new Client(
                new ProxyService(
                    new User()
                    {
                        Name = "administrator",
                        Role = UserRole.Administrator
                    }
                ));

            clientWithAdministratorUser.Operation($"{nameof(clientWithAdministratorUser)}");

            var clientWithUser = new Client(new ProxyService(
                    new User()
                    {
                        Name = "user",
                        Role = UserRole.User
                    }
                ));

            clientWithUser.Operation($"{nameof(clientWithUser)}");
        }
    }
}
