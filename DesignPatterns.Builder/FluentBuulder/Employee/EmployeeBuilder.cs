using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FluentBuulder.Employee
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
