using AutoMapper;
using MovieLibraryApi.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Numerics;

namespace MovieLibraryApi.Services
{
    public class ActorService:IActors
    {
        private MovieDB _movieDBContext;
        private IMapper _mapper;
        public ActorService(MovieDB movieDbContext, IMapper mapper)
        {
            _movieDBContext = movieDbContext;
            _mapper = mapper;
        }

        public async Task<ActorsDTO> PostActor(ActorsDTO actorsDTO)
        {
            var data = _mapper.Map<Actors>(actorsDTO);
            await _movieDBContext.Actorss.AddAsync(data);
            await _movieDBContext.SaveChangesAsync();
            return actorsDTO;
        }

        public async Task<Actors> DeleteActor(int id)
        {
            Actors Actor = await _movieDBContext.Actorss.FirstOrDefaultAsync(c => c.ActorID == id);
            _movieDBContext.Actorss.Remove(Actor);
            await _movieDBContext.SaveChangesAsync();

            return Actor;
        }

        public async Task<List<Actors>> GetActors()
        {
            var Actor = await _movieDBContext.Actorss.ToListAsync();

            return Actor;
        }

        public async Task<List<Actors>> GetActorByid(int id)
        {
            var ActorById = await _movieDBContext.Actorss.Where(m => m.ActorID == id).ToListAsync();

            return ActorById;
        }

        public async Task<ActorsDTO> PutActor(ActorsDTO actorsDTO, int id)
        {
            var Actor = _mapper.Map<Actors>(actorsDTO);
            Actor.ActorID = id;

            _movieDBContext.Actorss.Update(Actor);
            await _movieDBContext.SaveChangesAsync();

            return actorsDTO;
        }

        Task<Actors> IActors.PostActor(ActorsDTO actorDTO)
        {
            throw new NotImplementedException();
        }

        public Task<Actors> PutActor(int id, ActorsDTO actorDTO)
        {
            throw new NotImplementedException();
        }

        Task<string> IActors.DeleteActor(int id)
        {
            throw new NotImplementedException();
        }

        
        
    }
}
