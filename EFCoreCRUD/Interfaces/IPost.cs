using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreCRUD.Interfaces
{
    public interface IPost
    {
        public Task<DTOPost> AddPost(DTOPost DTOpost);
        public Task<List<Post>> GetAllPost();
        public Task<Post> UpdatePost(int id, DTOPost DTOpost);
        public Task<Post> DeletePost(int id);
    }
}
