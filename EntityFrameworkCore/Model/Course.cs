using System.Collections.Generic;

namespace EntityFrameworkCore.Model
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }
    }
}
