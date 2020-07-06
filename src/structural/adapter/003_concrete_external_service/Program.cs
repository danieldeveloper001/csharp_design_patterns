using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<IPerson>();

            var customers = new CustomerClient().Get();
            foreach(var customer in customers)
                people.Add(new CustomerToPersonAdapter(customer));

            var employees = new EmployeeClient().Get();
            foreach(var employee in employees)
                people.Add(new EmployeeToPersonAdapter(employee));

            var providers = new ProviderClient().Get();
            foreach(var provider in providers)
                people.Add(new ProviderToPersonAdapter(provider));

            foreach(var person in people)
            {
                Console.WriteLine($"{nameof(person.Name)}: {person.Name}");
                Console.WriteLine($"{nameof(person.CreatedAt)}: {person.CreatedAt}");
            }
        }
    }
}
