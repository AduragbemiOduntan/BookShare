using BookShare.Appliation.contracts;
using BookShare.Domain.Entities;
using BookShare.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Repositories
{
    public class BookRepository : RepositoryBase<Book>, IBookRepository
    {
        public BookRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateBook(Book book)
        {
            Create(book);
        }

        public void DeleteBook(Book book)
        {
            Delete(book);
        }

        public async Task<ICollection<Book>> GetAllBook()
        {
            return await FindAll().OrderBy(x => x.Id).ToListAsync();
        }

        public Task<Book> GetBookById(int bookId)
        {
            return FindByCondition(x => x.Id == bookId).FirstAsync();
        }

        public void UpdateBook(Book book)
        {
            Update(book);
        }
    }
}
