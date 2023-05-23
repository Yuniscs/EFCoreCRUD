using System;

namespace Repository
{
    public interface IUnitOfWork:IDisposable
    {
        public IRepository<Student> studentRepo { get; }
        

        void SaveChanges();
    }
}
