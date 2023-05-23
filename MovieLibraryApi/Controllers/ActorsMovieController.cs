using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieLibraryApi.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class ActorsMovieController : ControllerBase
    //{
    //    //IActorMovie ActorMovie;

    //    //public ActorsMovieController(IActorMovie movie)
    //    //{
    //    //    ActorMovie = movie;
    //    //}

    //    //[HttpGet]
    //    //public async Task<Movie> GetMoviieByTitle([FromQuery] string title, [FromQuery] string actorname)
    //    //{
    //    //    var data = await ActorMovie.GetMoviieByTitleActor(title, actorname);
    //    //    return data;
    //    //}

    //    //[HttpGet("{id}")]
    //    //public async Task<ICollection<Actors>> GetActorById([FromQuery] int id)
    //    //{
    //    //    var data = await ActorMovie.GetActorByMovieId(id);
    //    //    return data;
    //    //}
    //    //[HttpPost]
    //    //public async Task<Movie> PostMovieActor([FromQuery] ActorsMovieDTO actorMovieDto)
    //    //{
    //    //    var data = await ActorMovie.PostActorToMovie(actorMovieDto);
    //    //    return data;
    //    //}

    //    //[HttpDelete]
    //    //public async Task<string> DeleteMovie([FromQuery] int id)
    //    //{
    //    //    var data = await ActorMovie.DeleteActorsByIdFromMovie(id);
    //    //    return data;
    //    //}
       

    //}
}
