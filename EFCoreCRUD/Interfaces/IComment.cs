using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Interfaces
{
    public interface IComment
    {
        public IQueryable GetAllComment();
        public Task<Comment> AddComment(DTOComment DTOcomment);
        public Task<Comment> UpdateComment(int id, DTOComment DTOcomment);
        public Task<Comment> DeleteComment(int id);
    }
}
