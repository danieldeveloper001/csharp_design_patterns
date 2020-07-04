using System;
using System.Collections.Generic;

namespace Project
{
    public class EmployeeClient
    {

        private IList<Employee> _employees;

        public EmployeeClient()
        {
            // Creates data for simulating an external service request
            _employees = new List<Employee>();
            _employees.Add(new Employee()
                {
                    Name = "Employee 1",
                    EmployeeSince = new DateTime(2000, 01, 01)
                });
            _employees.Add(new Employee()
                {
                    Name = "Employee 2",
                    EmployeeSince = new DateTime(2000, 01, 02)
                });
            _employees.Add(new Employee()
                {
                    Name = "Employee 3",
                    EmployeeSince = new DateTime(2000, 01, 03)
                });
        }

        public IList<Employee> Get()
        {
            return _employees;
        }
    }
}
