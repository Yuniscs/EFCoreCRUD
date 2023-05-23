using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;

namespace ManyToManyCRUD.Domain.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string Email { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
            = new List<Enrollment>();
    }
}
