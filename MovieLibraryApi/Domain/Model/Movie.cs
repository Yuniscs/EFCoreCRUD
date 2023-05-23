using System;
using System.Collections.Generic;

namespace MovieLibraryApi.Domain.Model
{
    public class Movie
    {

        public int MovieID { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Title { get; set; }

        public ICollection<ActorsMovie> ActorsMovies { get; set; }

    }
}
