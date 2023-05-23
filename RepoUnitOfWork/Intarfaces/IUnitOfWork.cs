using RepoUnitOfWork.Models;
using System;
using System.Threading.Tasks;

namespace RepoUnitOfWork.Intarfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IStudentRepository<Student> studentRepo { get; }
        public ICourseRepository<Course> courseRepo { get; }


        void SaveChanges();
        //Task SaveChangesAsync();
        //Task SaveChangesAsync();
    }
}
