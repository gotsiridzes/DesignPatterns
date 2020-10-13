using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FluentBuulder.Employee
{
    public class EmployeeInfoBuilder<T> : EmployeeBuilder
        where T : EmployeeInfoBuilder<T>
    {
        public T Called(string name)
        {
            employee.Name = name;
            return (T)this;
        }
    }
}
