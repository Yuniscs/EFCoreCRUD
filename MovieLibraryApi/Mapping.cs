using AutoMapper;
using MovieLibraryApi.Domain;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;

namespace MovieLibraryApi
{
    public class Mapping : Profile
    {
        public Mapping()
        {
            
            //CreateMap<Movie, Movie>();
            CreateMap<MovieDTO, Movie>();
            CreateMap<ActorsDTO, Actors>();
        }
    }
}
