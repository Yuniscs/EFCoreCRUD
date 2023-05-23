using Microsoft.EntityFrameworkCore;
using RepoUnitOfWork.Intarfaces;
using RepoUnitOfWork.Models;
using System.Collections.Generic;
using System.Linq;

namespace RepoUnitOfWork.Repositories
{
    public class StudentRepository<TEntity> : IStudentRepository<TEntity> where TEntity : class
    {

        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entitySet;
        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
            _entitySet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entitySet.ToList();
        }

        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }


        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }
    }
}
