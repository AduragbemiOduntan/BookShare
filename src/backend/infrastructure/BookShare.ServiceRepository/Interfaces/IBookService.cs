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
    public interface IBookService
    {
        Task<ICollection<BookForRead>> GetAllBooksAsync();
        Task<BookForRead> GetBookByIdAsync(int bookId);
        Task<BookForCreation> CreateBookAsync(BookForCreation bookForCreation);
        Task UpdateBookAsync(int bookId, BookForUpdate bookForUpdate);
        Task DeleteBookAsynnc(int bookId);
    }
}
