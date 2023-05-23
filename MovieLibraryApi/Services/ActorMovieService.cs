using AutoMapper;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MovieLibraryApi.Services
{
    //public class ActorMovieService:IActorMovie
    //{
    //    MovieDB _movieDB;
    //    IMapper _mapper;
    //    public ActorMovieService(IMapper mapper,MovieDB movieDB)
    //    {
    //        _movieDB =  movieDB ;
    //        _mapper = mapper;
    //    }
    //    public async Task<ICollection<Actors>> GetActorByMovieId(int id)
    //    {
    //        try
    //        {
    //            var data = await _movieDB.Movies.Include(m => m.Actors).FirstOrDefaultAsync(m => m.Id == id);
    //            var return_data = data.Actorss;
    //            return return_data;
    //        }
    //        catch (Exception ex)
    //        {
    //            var log = ex.Message;
    //            var log_inner = ex.InnerException;
    //            return null;
    //        }
    //    }

    //    public async Task<Movie> GetMoviieByTitleActor(string title, string actorname)
    //    {
    //        try
    //        {
    //            var data = await _movieDB.Movies.Include(m => m.Actorss).FirstOrDefaultAsync(m => m.Title == title);
    //            var data_2 = data.Actorss.FirstOrDefault(a => a.Name == actorname);
    //            if (data != null && data_2 != null)
    //            {
    //                return data;
    //            }
    //            else return null;
    //        }
    //        catch (Exception ex)
    //        {
    //            var log = ex.Message;
    //            var log_inner = ex.InnerException;
    //            return null;
    //        }
    //    }

    //    public async Task<Movie> PostActorToMovie(ActorsMovieDTO actorMovieDto)
    //    {
    //        try
    //        {
    //            var data = await _movieDB.Movies.Include(m => m.Actorss).FirstOrDefaultAsync(
    //                 m => m.Title == actorMovieDto.MovieTitle &&
    //                  m.ReleaseYear == actorMovieDto.MovieReleaseYear &&
    //                  m.Genre == actorMovieDto.MovieGenre &&
    //                  m.Director == actorMovieDto.MovieDirector);

    //            var data_2 = await _movieDB.Actorss.SingleOrDefaultAsync(a => a.Name == actorMovieDto.ActorName);
    //            if (data != null && data_2 != null) data.Actorss.Add(data_2);
    //            else
    //            {
    //                data.Actorss.Add(new Actors { Name = actorMovieDto.ActorName });
    //            }
    //            await _movieDB.SaveChangesAsync();
    //            var return_value = await _movieDB.Movies.Include(m => m.Actorss).OrderByDescending(m => m.Id)
    //                .FirstOrDefaultAsync(m => m.Title == actorMovieDto.MovieTitle);
    //            return return_value;
    //        }
    //        catch (Exception ex)
    //        {
    //            var log = ex.Message;
    //            var log_inner = ex.InnerException;
    //            return null;
    //        }
    //    }

    //    public async Task<string> DeleteActorsByIdFromMovie(int id)
    //    {
    //        try
    //        {
    //            var data = await _movieDB.Movies.Include(m => m.Actorss).FirstOrDefaultAsync(m => m.Id
    //            == id);

    //            if (data != null)
    //            {
    //                foreach (var item in data.Actorss)
    //                {
    //                    data.Actorss.Remove(item);
    //                }
    //                await _movieDB.SaveChangesAsync();
    //                return "Succesful";
    //            }
    //            else return "This id is not registered";
    //        }
    //        catch (Exception ex)
    //        {
    //            var log = ex.Message;
    //            var log_inner = ex.InnerException;
    //            return "Failed";
    //        }
    //    }

        
    //}
}
