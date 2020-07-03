using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person() { Name = "name" };

            PersonAdapter customer = new PersonToCustomerAdapter(person);
            Console.WriteLine(customer.Name);

            PersonAdapter employee = new PersonToEmployeeAdapter(person);
            Console.WriteLine(employee.Name);

            PersonAdapter provider = new PersonToProviderAdapter(person);
            Console.WriteLine(provider.Name);
        }
    }
}
