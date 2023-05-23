using MovieLibraryApi.Domain;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryApi.Interfaces
{
    public interface IMovie
    {
        
        public Task<List<Movie>> GetMovies();
        public Task<List<Movie>> GetMovieByid(int id);
        public Task<MovieDTO> PostMovie(MovieDTO movieDTO);
        //public Task<MovieDTO> PutMovie(int id, MovieDTO movieDTO);
        public Task<Movie> DeleteMovie(int id);
        public Task<MovieDTO> PutMovie(MovieDTO movieDTO, int id);



        public Task<Actors> GetActorList(int movieId);

    }
}
