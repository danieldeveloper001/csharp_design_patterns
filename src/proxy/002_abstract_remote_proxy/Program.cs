using System;
using Local;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new ProxyService());

            client.Operation($"{nameof(client)}");
        }
    }
}
