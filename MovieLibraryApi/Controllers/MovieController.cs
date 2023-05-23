using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryApi.Domain;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovie _movie;
        public MovieController(IMovie movie)
        {
            _movie = movie;
        }

        [HttpGet]
        public Task<List<Movie>> GetMovies()
        {
            return _movie.GetMovies();
        }

        [HttpGet("{id}")]
        public Task<List<Movie>> GetMovieByid(int id)
        {
            return _movie.GetMovieByid(id);
        }
        [HttpPost]
        public Task<MovieDTO> PostMovie([FromQuery] MovieDTO movieDTO)
        {
            return _movie.PostMovie(movieDTO);
        }

        [HttpPut]
        public Task<MovieDTO> PutMovie([FromQuery] MovieDTO movieDTO, int id)
        {
            return _movie.PutMovie(movieDTO, id);
        }

        [HttpDelete]
        public Task<Movie> DeleteMovie(int id)
        {
            return _movie.DeleteMovie(id);
        }

        [HttpGet("{movieId}")]
        public async Task<Actors> GetActorList(int movieId)
        {
            return await _movie.GetActorList(movieId);
        }

    }
}
