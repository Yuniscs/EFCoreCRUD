using EFCoreCRUD.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUD.Domain
{
    public class EFDbContext:DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public EFDbContext(DbContextOptions<EFDbContext>options):base (options)
        {

        }
        //Verilənlər bazasına qoşulmaq və saxlamaq və ya əldə etmək və ya məlumatları əldə etmək üçündur
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    modelBuilder.Entity<Comment>()
        //       .HasOne<Post>(s => s.Post)
        //       .WithMany(g => g.Comments)
        //       .HasForeignKey(fk => fk.PostId)
        //       .OnDelete(DeleteBehavior.Restrict);

        //    //    //modelBuilder.Entity<Post>()
        //    //    //    .HasMany<Comment>(s => s.Comments)
        //    //    //    .WithOne(g => g.Post)
        //    //    //    .HasForeignKey(s => s.PostId)
        //    //    //    .OnDelete(DeleteBehavior.Cascade);
        //}
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=WIN-PSBFAS1N9S1\SQLEXPRESS;Database=PostCommentDb;Trusted_Connection=True;");
        //}


    }
}
