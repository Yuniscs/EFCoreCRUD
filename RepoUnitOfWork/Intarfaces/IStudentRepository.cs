using RepoUnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepoUnitOfWork.Intarfaces
{
    public interface IStudentRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        //Task ToListAsync();
        //Task AddAsync(Student model);
        //Task FirstOrDefaultAsync(Func<object, bool> value);
        //void Remove();
        //Task FirstOrDefaultAsync();
    }
}
