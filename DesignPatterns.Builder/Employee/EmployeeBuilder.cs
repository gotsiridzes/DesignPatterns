using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.Employee
{
    public abstract class EmployeeBuilder
    {
        protected Employee employee = new Employee();

        public Employee Build()
        {
            return employee;
        }
    }
}
