using ManyToManyCRUD.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ManyToManyCRUD.Domain
{
    public class EnrolmentDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        public EnrolmentDbContext(DbContextOptions<EnrolmentDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Student)
                .OnDelete(DeleteBehavior.SetNull);

            modelBuilder.Entity<Course>()
                .HasMany(s => s.Enrollments)
                .WithOne(e => e.Course)
                .OnDelete(DeleteBehavior.SetNull);
           

        }
    }
}
