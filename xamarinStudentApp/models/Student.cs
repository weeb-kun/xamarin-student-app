using System;
using System.Collections.Generic;
using System.Text;

namespace xamarinStudentApp.models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string? StudentName { get; set; }
        public int? StandardId { get; set; }
        public virtual Standard? Standard { get; set; }
        public virtual StudentAddress StudentAddress { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
