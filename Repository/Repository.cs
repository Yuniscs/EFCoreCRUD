using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity :  class
    {
        private ApplicationDbContext _context;
        private readonly DbSet<TEntity> _entitySet;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            _entitySet = context.Set<TEntity>();
        }
        

        public void Add(TEntity entity)
        {
            _context.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entitySet.ToList();
        }

        public void Update(TEntity entity)
        {
            _context.Update(entity);
        }
    }
}
