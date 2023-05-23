using AutoMapper;
using EFCoreCRUD.Domain;
using EFCoreCRUD.Domain.Entities;
using EFCoreCRUD.DTO;
using EFCoreCRUD.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCRUD.Repository
{
    public class CommentRepository:IComment
    {
        private EFDbContext efDbContext;
        private IMapper mapper;

        public CommentRepository(EFDbContext _efDbContext, IMapper _mapper)
        {
            efDbContext = _efDbContext;
            mapper = _mapper;
        }

        public IQueryable GetAllComment()
        {

            var data = from s in efDbContext.Comments
                       select new { Id = s.Id, AuthorId = s.AuthorId, Text = s.Text, Post = s.Post };

            return data;
        }

        public async Task<Comment> AddComment(DTOComment DTOcomment)
        {
            var data = mapper.Map<Comment>(DTOcomment);
            await efDbContext.Comments.AddAsync(data);
            await efDbContext.SaveChangesAsync();
            return data;
        }

        public async Task<Comment> UpdateComment(int id, DTOComment DTOcomment)
        {

            var oldData = await efDbContext.Comments.FirstOrDefaultAsync(s => s.Id == id);
            var newData = mapper.Map<Comment>(DTOcomment);
            efDbContext.Entry(oldData).CurrentValues.SetValues(newData);
            await efDbContext.SaveChangesAsync();
            return newData;
        }

        public async Task<Comment> DeleteComment(int id)
        {
            Comment comment = efDbContext.Comments.FirstOrDefault(s => s.Id == id);
            efDbContext.Comments.Remove(comment);
            await efDbContext.SaveChangesAsync();
            return comment;
        }
    }
}
