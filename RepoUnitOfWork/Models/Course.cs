using System.Collections;
using System.Collections.Generic;

namespace RepoUnitOfWork.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CoursName { get; set; }
        public string Description { get; set; }
        public int StudentId { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
