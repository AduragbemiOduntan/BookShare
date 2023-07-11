using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using BookShare.ServiceRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    internal sealed class BookService : IBookService
    {
        private IRepositoryManager _repsositoryManager;
        private ILoggerManager _loggerManager;
        private IMapper _mapper;

        public BookService(IRepositoryManager repositoryManager, ILoggerManager logerManager, IMapper mapper)
        {
            _repsositoryManager = repositoryManager;
            _loggerManager = logerManager;
            _mapper = mapper;
        }

        public Task<BookForCreation> CreateBookAsync(BookForCreation bookForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookAsynnc(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<BookForRead>> GetAllBooksAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookForRead> GetBookByIdAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBookAsync(int bookId, BookForUpdate bookForUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
