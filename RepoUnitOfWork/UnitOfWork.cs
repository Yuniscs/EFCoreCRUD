using RepoUnitOfWork.Intarfaces;
using RepoUnitOfWork.Models;
using RepoUnitOfWork.Repositories;
using System.Threading.Tasks;

namespace RepoUnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _applicationDbContext;

        public IStudentRepository<Student> studentRepo => throw new System.NotImplementedException();

        public ICourseRepository<Course> courseRepo => throw new System.NotImplementedException();

        public IStudentRepository<Student> _studentRepository;
        public ICourseRepository<Course> _courseRepository;

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IStudentRepository<Student> StudentRepo
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new StudentRepository<Student>(_applicationDbContext);
                }
                return _studentRepository;
            }
        }
        public ICourseRepository<Course> CourseRepo
        {
            get
            {
                if (_courseRepository == null)
                {
                    _courseRepository = new CourseRepository<Course>(_applicationDbContext);
                }
                return _courseRepository;
            }
        }

        

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Dispose()
        {
            _applicationDbContext.Dispose();
        }

        public void SaveChangesAsync()
        {
            _applicationDbContext.SaveChangesAsync();
        }

        
    }
}

