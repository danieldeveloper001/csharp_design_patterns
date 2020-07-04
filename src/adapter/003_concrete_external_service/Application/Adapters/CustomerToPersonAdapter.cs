using System;

namespace Project
{
    public class CustomerToPersonAdapter : IPerson
    {
        private Customer _customer;

        public string Name => _customer.Name;
        public DateTime CreatedAt => _customer.CustomerSince;

        public CustomerToPersonAdapter(Customer customer)
        {
            _customer = customer;
        }

    }
}
