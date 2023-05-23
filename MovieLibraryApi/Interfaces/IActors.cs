using MovieLibraryApi.Domain.Model;
using MovieLibraryApi.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryApi.Interfaces
{
    public interface IActors
    {
        
        public Task<List<Actors>> GetActors();
        public Task<List<Actors>> GetActorByid(int id);
        public Task<ActorsDTO> PostActor(ActorsDTO actorDTO);
        public Task<ActorsDTO> PutActor(int id, ActorsDTO actorDTO);
        public Task<Actors> DeleteActor(int id);
        Task<ActorsDTO> PutActor(ActorsDTO addActorDTO, int id);
    }
}
