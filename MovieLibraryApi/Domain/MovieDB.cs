using Microsoft.EntityFrameworkCore;
using MovieLibraryApi.Domain.Model;

namespace MovieLibraryApi.Domain
{
    public class MovieDB:DbContext
    {
        public MovieDB(DbContextOptions<MovieDB> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actors> Actorss { get; set; }
        public DbSet<ActorsMovie> ActorsMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorsMovie>().HasKey(s => new { s.MovieId, s.ActorId, s.MovieActorID });

            modelBuilder.Entity<ActorsMovie>()
                .HasOne<Movie>(ma => ma.Movie)
                .WithMany(m => m.ActorsMovies)
                .HasForeignKey(ma => ma.MovieId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ActorsMovie>()
                .HasOne<Actors>(ma => ma.Actors)
                .WithMany(a => a.ActorsMovies)
                .HasForeignKey(ma => ma.ActorId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
