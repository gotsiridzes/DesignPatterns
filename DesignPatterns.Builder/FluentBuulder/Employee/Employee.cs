using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FluentBuulder.Employee
{
    public class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public static Builder New => new Builder();

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}. {nameof(Position)}: {Position}.";
        }

        public class Builder : EmployeeJobBuilder<Builder> { }
    }
}
