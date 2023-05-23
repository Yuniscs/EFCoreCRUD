using AutoMapper;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MovieLibraryApi.Domain;
using MovieLibraryApi.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Numerics;

namespace MovieLibraryApi.Services
{
    public class MovieService : IMovie
    {
        private MovieDB _movieDbContext;
        private IMapper _mapper;
        public MovieService(MovieDB movieDbContext, IMapper mapper)
        {
            _movieDbContext = movieDbContext;
            _mapper = mapper;
        }

        public async Task<MovieDTO> PostMovie(MovieDTO movieDTO)
        {

            var data = _mapper.Map<Movie>(movieDTO);
            await _movieDbContext.Movies.AddAsync(data);
            await _movieDbContext.SaveChangesAsync();
            return movieDTO;
        }

        public async Task<Movie> DeleteMovie(int id)
        {
            Movie Movie = await _movieDbContext.Movies.FirstOrDefaultAsync(c => c.MovieID == id);
            _movieDbContext.Movies.Remove(Movie);
            await _movieDbContext.SaveChangesAsync();

            return Movie;
        }

        public async Task<List<Movie>> GetMovies()
        {
            var Movie = await _movieDbContext.Movies.ToListAsync();

            return Movie;
        }

        public async Task<List<Movie>> GetMovieByid(int id)
        {
            var MovieById = await _movieDbContext.Movies.Where(m => m.MovieID == id).ToListAsync();

            return MovieById;
        }

        public async Task<MovieDTO> PutMovie(MovieDTO addMovieDTO, int id)
        {
            var Movie = _mapper.Map<Movie>(addMovieDTO);
            Movie.MovieID = id;

            _movieDbContext.Movies.Update(Movie);
            await _movieDbContext.SaveChangesAsync();

            return addMovieDTO;
        }

        public async Task<Actors> GetActorList(int movieId)
        {
            var data = await _movieDbContext.Actorss.Include(a => a.ActorsMovies.Where(m => m.MovieId == movieId)).FirstOrDefaultAsync();

            return data;
        }

        
    }
}
