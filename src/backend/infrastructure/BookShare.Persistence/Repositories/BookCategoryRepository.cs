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
    public class BookCategoryRepository : RepositoryBase<BookCategory>, IBookCategoryRepository
    {
        public BookCategoryRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateBookCategory(BookCategory bookCategory)
        {
            Create(bookCategory);   
        }

        public void DeleteBookCategory(BookCategory bookCategory)
        {
            Delete(bookCategory);
        }

        public async Task<ICollection<Book>> GetAllBookCategory()
        {
            return await FindAll().OrderBy(x => x.BookCategoryId).ToListAsync(); ;
        }

        public Task<BookCategory> GetByBookCategoryName(string bookCategoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateBookCategory(BookCategory bookCategory)
        {
            throw new NotImplementedException();
        }
    }
}
