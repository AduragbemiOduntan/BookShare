using AutoMapper;
using BookShare.Appliation.common;
using BookShare.ServiceRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<IBookCategoryService> _bookCategoryService;
        private readonly Lazy<IBookService> _bookService;
        private readonly Lazy<IDonationService> _donationService;
        private readonly Lazy<IUserService> _userService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper)
        {
    /*        _bookCategoryService = new Lazy<IBookCategoryService>(() =>
            new BookCategoryService(repositoryManager, loggerManager, mapper));
            _bookService = new Lazy<IBookService>(() =>
            new BookService(repositoryManager, loggerManager, mapper));
            _donationService = new Lazy<IUserService>(() =>
            new DonationService(repositoryManager, loggerManager, mapper));*/
            _userService = new Lazy<IUserService>(() =>
            new UserService(repositoryManager, loggerManager,mapper));
        }

        public IBookCategoryService BookCategoryService => _bookCategoryService.Value;
        public IBookService BookService => _bookService.Value;
        public IDonationService DonationService => _donationService.Value;
        public IUserService UserService => _userService.Value;
    }
}
