using System.Collections;
using System.Collections.Generic;

namespace MovieLibraryApi.Domain.Model
{
    public class Actors
    {

        public int ActorID { get; set; }
        public string ActorName { get; set; }

        public ICollection<ActorsMovie> ActorsMovies { get; set; }

    }
}
