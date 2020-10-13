using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FluentBuulder.Employee
{
    public class EmployeeJobBuilder<T> : EmployeeInfoBuilder<EmployeeJobBuilder<T>>
        where T : EmployeeJobBuilder<T>
    {
        public T WorksAs(string position)
        {
            employee.Position = position;
            return (T)this;
        }
    }
}
