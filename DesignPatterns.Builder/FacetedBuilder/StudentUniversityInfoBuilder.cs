using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FacetedBuilder
{
    public class StudentUniversityInfoBuilder : StudentBuilder
    {
        public StudentUniversityInfoBuilder(Student student)
        {
            this.student = student;
        }

        public StudentUniversityInfoBuilder At(string university)
        {
            student.University = university;
            return this;
        }

        public StudentUniversityInfoBuilder On(string faculty)
        {
            student.Faculty = faculty;
            return this;
        }
    }
}
