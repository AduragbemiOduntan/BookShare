using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync(bool trackChanges);
        Task<Book> GetBookByBookIdAsync(int BookId, bool trackChanges);
        void CreateBook(Book book);
        void DeleteBook(Book book);
    }
}
