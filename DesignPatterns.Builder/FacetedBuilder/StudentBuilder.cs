using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Builder.FacetedBuilder
{
    // Facade for other builders
    public class StudentBuilder
    {
        // reference object
        protected Student student = new Student();

        public StudentUniversityInfoBuilder Studies => new StudentUniversityInfoBuilder(student);
        public StudentPersonalInfoBuilder Is => new StudentPersonalInfoBuilder(student);

        // არაა მაინცდამაინც კარგი მეთოდი მაგრამ მუშაობს
        public static implicit operator Student(StudentBuilder sb) => sb.student;
    }
}
