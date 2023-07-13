using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Interfaces
{
    public interface IBookCategoryService
    {
        Task<ICollection<BookCategoryForRead>> GetAllBookCategoryAsync();
        Task<BookCategoryForRead> GetBookCategoryByNameAsync(string bookCategoryName);
        Task<BookCategoryForCreation> CreateBookCategoryAsync(BookCategoryForCreation bookCategoryForCreation);
       /* Task UpdateBookCategoryAsync(int bookCategoryId, BookCategoryForUpdate bookCategoryForUpdate);*/
        Task DeleteBookCategoryAsynnc(string bookCategoryId);
    }
}
