using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer
{
    public class BookServices
    {
        public ApplicationDbContext _applicationDbContext;
        public BookServices(ApplicationDbContext applicationDbContext )
        {
            _applicationDbContext = applicationDbContext;
        }
        public void AddBook(Book book)
        {
            _applicationDbContext.Books.Add(book);
        }
        public void DeleteBook(Book book)
        {
            _applicationDbContext.Books.Remove(book);
        }
        public async Task<Book>GetBook(int id)
        {
            return await _applicationDbContext.Books.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
