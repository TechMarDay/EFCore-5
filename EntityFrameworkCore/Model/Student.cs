using System.Collections.Generic;

namespace EntityFrameworkCore.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CurrentGradeId { get; set; }

        public Grade Grade { get; set; }

        public StudentAddress Address { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
