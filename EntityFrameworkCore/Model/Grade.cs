using System.Collections.Generic;

namespace EntityFrameworkCore.Model
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string GradeName { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
