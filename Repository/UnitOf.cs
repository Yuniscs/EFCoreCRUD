namespace Repository
{
    public class UnitOf : IUnitOfWork
    {
        private ApplicationDbContext _applicationDbContext;
        public IRepository<Student> _studentRepository;

        public IRepository<Student> studentRepo => throw new System.NotImplementedException();

        public UnitOf(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

       public IRepository<Student> StudentRepo
        {
            get
            {
                if (_studentRepository == null)
                {
                    _studentRepository = new Repository<Student>(_applicationDbContext);
                }
                return _studentRepository;
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
    }
}
