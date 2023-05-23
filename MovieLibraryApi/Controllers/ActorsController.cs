using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using MovieLibraryApi.Interfaces;
using MovieLibraryApi.Services;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;

namespace MovieLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        private IActors _actors;
        public ActorsController(IActors actors)
        {
            _actors = actors;
        }

        [HttpGet]
        public async Task<List<Actors>> GetActors()
        {
            return await _actors.GetActors();
        }

        [HttpGet("{id}")]
        public async Task<List<Actors>> GetActorByid(int id)
        {
            return await _actors.GetActorByid(id);
        }

        [HttpPost]
        public async Task<ActorsDTO> AddActor([FromQuery] ActorsDTO addActorDTO)
        {
            return await _actors.PostActor(addActorDTO);
        }

        [HttpPut]
        public async Task<ActorsDTO> UpdateActor([FromQuery] ActorsDTO addActorDTO, int id)
        {
            return await _actors.PutActor(addActorDTO, id);
        }

        [HttpDelete]
        public async Task<Actors> DeleteActor(int id)
        {
            return await _actors.DeleteActor(id);
        }
    }
}
