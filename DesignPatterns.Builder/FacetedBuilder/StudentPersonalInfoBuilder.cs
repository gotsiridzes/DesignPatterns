using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FacetedBuilder
{
    public class StudentPersonalInfoBuilder : StudentBuilder
    {
        public StudentPersonalInfoBuilder(Student student)
        {
            this.student = student;
        }

        public StudentPersonalInfoBuilder Called(string name)
        {
            student.Name = name;
            return this;
        }
    }
}
