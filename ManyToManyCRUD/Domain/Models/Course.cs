using System.Collections.Generic;

namespace ManyToManyCRUD.Domain.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string CoursName { get; set; }
        public string Description { get; set; }

        public ICollection<Enrollment>  Enrollments { get; set; } 
            = new List<Enrollment>();
    }
}
