using System.Collections;
using System.Collections.Generic;

namespace Repository
{
    public interface IRepository<TEntity>where TEntity:class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
    }
}
