using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.contracts
{
    public interface IBookCategoryRepository
    {
        void CreateBookCategory(BookCategory bookCategory);
       
        Task<ICollection<BookCategory>> GetAllBookCategory();

        Task<BookCategory> GetByBookCategoryName(string bookCategoryName);

        void UpdateBookCategory(BookCategory bookCategory);

        void DeleteBookCategory(BookCategory bookCategory);
    }
}
