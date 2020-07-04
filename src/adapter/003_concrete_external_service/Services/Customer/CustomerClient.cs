using System;
using System.Collections.Generic;

namespace Project
{
    public class CustomerClient
    {

        private IList<Customer> _customers;

        public CustomerClient()
        {
            // Creates data for simulating an external service request
            _customers = new List<Customer>();
            _customers.Add(new Customer()
                {
                    Name = "Customer 1",
                    CustomerSince = new DateTime(2000, 01, 01)
                });
            _customers.Add(new Customer()
                {
                    Name = "Customer 2",
                    CustomerSince = new DateTime(2000, 01, 02)
                });
            _customers.Add(new Customer()
                {
                    Name = "Customer 3",
                    CustomerSince = new DateTime(2000, 01, 03)
                });
        }

        public IList<Customer> Get()
        {
            return _customers;
        }
    }
}
