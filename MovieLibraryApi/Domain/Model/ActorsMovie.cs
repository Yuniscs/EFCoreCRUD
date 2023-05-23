using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MovieLibraryApi.Domain.Model
{
    public class ActorsMovie
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieActorID { get; set; }

        public int ActorId { get; set; }
        public Actors Actors { get; set; }

        public int MovieId { get; set; }
        public Movie Movie { get; set; }
    }
}
