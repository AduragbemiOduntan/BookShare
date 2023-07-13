using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.contracts
{
    public interface IBookRepository
    {
        void CreateBook(Book book);
        Task<ICollection<Book>> GetAllBook();
        Task<Book> GetBookById(string bookId);
        void UpdateBook(Book book);
        void DeleteBook(Book book);
    }
}
