using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.SOLID.DependencyInversionPrinciple
{
    public class Person
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
    }
}
