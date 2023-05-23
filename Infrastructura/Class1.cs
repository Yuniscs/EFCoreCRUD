using System;
using System.Data.Entity;

namespace Infrastructura
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<User>Users
    }
}
