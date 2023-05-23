using AutoMapper;
using EFCoreCRUD.Domain;
using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using EFCoreCRUD.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Repository
{
    
    public class PostRepository:IPost
    {
        private EFDbContext efDbContext;
        private IMapper mapper;

        public PostRepository(EFDbContext _efDbContext, IMapper _mapper)
        {
            efDbContext = _efDbContext;
            mapper = _mapper;
        }

       
        public async Task<List<Post>> GetAllPost()
        {           
            var data = await (from s in efDbContext.Posts
                              select new Post
                              {
                                  AuthorId = s.AuthorId,
                                  Comments = s.Comments,
                                  Id = s.Id,
                                  PublishedData = s.PublishedData,
                                  Text = s.Text
                              }).ToListAsync();

            return data;

            
        }

        public async Task<DTOPost> AddPost(DTOPost DTOpost)
        {
            var data = mapper.Map<Post>(DTOpost);
            await efDbContext.Posts.AddAsync(data);
            await efDbContext.SaveChangesAsync();
            return DTOpost;
        }

        public async Task<Post> UpdatePost(int id, DTOPost DTOpost)
        {

            var oldData = await efDbContext.Posts.FirstOrDefaultAsync(s => s.Id == id);
            oldData.Text = DTOpost.Text;
            oldData.AuthorId = DTOpost.AuthorId;
            oldData.PublishedData = DTOpost.PublishedData;
            var newData = mapper.Map<Post>(DTOpost);
           
            efDbContext.Entry(oldData).CurrentValues.SetValues(newData);
            await efDbContext.SaveChangesAsync();
            return newData;
        }

        public async Task<Post> DeletePost(int id)
        {
            Post post = efDbContext.Posts.FirstOrDefault(s => s.Id == id);
            efDbContext.Posts.Remove(post);
            await efDbContext.SaveChangesAsync();
            return post;
        }


    }
}
