using System.Collections;
using System.Collections.Generic;

namespace RepoUnitOfWork.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }
        public int CourseId { get; set; }

        public ICollection<Course> Course { get; set; }
    }
}
