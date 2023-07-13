using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.ServiceRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    internal sealed class BookCategoryService : IBookCategoryService
    {
        private IRepositoryManager _repsositoryManager;
        private ILoggerManager _loggerManager;
        private IMapper _mapper;

        public BookCategoryService(IRepositoryManager repositoryManager, ILoggerManager logerManager, IMapper mapper)
        {
            _repsositoryManager = repositoryManager;
            _loggerManager = logerManager;
            _mapper = mapper;
        }

        public Task<BookCategoryForCreation> CreateBookCategoryAsync(BookCategoryForCreation bookCategoryForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBookCategoryAsynnc(string bookCategoryId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<BookCategoryForRead>> GetAllBookCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BookCategoryForRead> GetBookCategoryByNameAsync(string bookCategoryName)
        {
            throw new NotImplementedException();
        }
    }
}
