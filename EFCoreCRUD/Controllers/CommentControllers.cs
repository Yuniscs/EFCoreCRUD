using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using EFCoreCRUD.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentControllers : Controller
    {

        private IComment intrepository;
        public CommentControllers(IComment _intrepository)
        {
            intrepository = _intrepository;
        }

        [HttpGet]
        public IQueryable GetAllComments()
        {
            
            return intrepository.GetAllComment();
        }

        [HttpPost]
        public async Task<Comment> AddComment([FromQuery] DTOComment commentDTO)
        {
            return await intrepository.AddComment(commentDTO);
        }
        [HttpPut]
        public async Task<Comment> UpdateComment(int id, [FromQuery] DTOComment commentDTO)
        {
            return await intrepository.UpdateComment(id, commentDTO);
        }
        [HttpDelete]
        public async Task<Comment> DeleteComment(int id)
        {
            return await intrepository.DeleteComment(id);
        }


    }
}
