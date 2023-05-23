using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using EFCoreCRUD.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace EFCoreCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PostControllers : Controller
    {
        private IPost intrepository;
        public PostControllers(IPost _intrepository)
        {
            intrepository = _intrepository;
        }

        [HttpGet]
        public async Task<Post> GetAllPost()
        {
            
            return null;
        }

        [HttpPost]
        public async Task<DTOPost> AddPost([FromQuery] DTOPost DTOpost)
        {
            return await intrepository.AddPost(DTOpost);
        }
        [HttpPut]
        public async Task<Post> UpdatePost(int id, [FromQuery]DTOPost DTOpost)
        {
            return await intrepository.UpdatePost(id, DTOpost);
        }
        [HttpDelete]
        public async Task<Post> DeletePost(int id)
        {
            return await intrepository.DeletePost(id);
        }

    }
}
