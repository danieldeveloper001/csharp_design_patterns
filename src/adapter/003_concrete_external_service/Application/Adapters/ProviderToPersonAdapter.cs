using System;

namespace Project
{
    public class ProviderToPersonAdapter : IPerson
    {
        private Provider _provider;

        public string Name => _provider.Name;

        public DateTime CreatedAt => _provider.ProviderSince;

        public ProviderToPersonAdapter(Provider provider)
        {
            _provider = provider;
        }
    }
}
