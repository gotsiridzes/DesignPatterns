using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FacetedBuilder
{
    public class Student
    {
        // Personal Info
        public string Name { get; set; }

        // University Data
        public string University { get; set; }
        public string Faculty { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(University)}: {University}, {nameof(Faculty)}: {Faculty}.";
        }
    }
}
