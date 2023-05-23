using Microsoft.EntityFrameworkCore;
using RepoUnitOfWork.Intarfaces;
using RepoUnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepoUnitOfWork.Repositories
{
    public class CourseRepository<TEntity> : ICourseRepository<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entitySet;
        public CourseRepository(ApplicationDbContext context)
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

        public Task ToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task FirstOrDefaultAsync(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }

        public void Remove()
        {
            throw new NotImplementedException();
        }
    }
    
}
