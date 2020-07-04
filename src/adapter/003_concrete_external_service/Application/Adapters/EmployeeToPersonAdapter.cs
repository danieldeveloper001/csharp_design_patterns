using System;

namespace Project
{
    public class EmployeeToPersonAdapter : IPerson
    {
        private Employee _employee;

        public string Name => _employee.Name;
        public DateTime CreatedAt => _employee.EmployeeSince;

        public EmployeeToPersonAdapter(Employee employee)
        {
            _employee = employee;
        }
    }
}
