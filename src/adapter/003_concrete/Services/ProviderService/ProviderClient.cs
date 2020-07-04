using System;
using System.Collections.Generic;

namespace Project
{
    public class ProviderClient
    {

        private IList<Provider> _providers;

        public ProviderClient()
        {
            // Creates data for simulating an external service request
            _providers = new List<Provider>();
            _providers.Add(new Provider()
                {
                    Name = "Provider 1",
                    ProviderSince = new DateTime(2000, 01, 01)
                });
            _providers.Add(new Provider()
                {
                    Name = "Provider 2",
                    ProviderSince = new DateTime(2000, 01, 02)
                });
            _providers.Add(new Provider()
                {
                    Name = "Provider 3",
                    ProviderSince = new DateTime(2000, 01, 03)
                });
        }

        public IList<Provider> Get()
        {
            return _providers;
        }
    }
}
