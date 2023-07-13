using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Domain.Entities;
using BookShare.ServiceRepository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
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
     /*   private readonly Lazy<IUserService> _userService;*/
        private readonly Lazy<IAuthenticationService> _authenticationService;



        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager loggerManager, IMapper mapper, UserManager<User> userManager, IConfiguration configuration)
        {
           /* _bookCategoryService = new Lazy<IBookCategoryService>(() =>
            new BookCategoryService(repositoryManager, loggerManager, mapper));
            _bookService = new Lazy<IBookService>(() =>
            new BookService(repositoryManager, loggerManager, mapper));
            _donationService = new Lazy<IUserService>(() =>
            new DonationService(repositoryManager, loggerManager, mapper));*/
           /* _userService = new Lazy<IUserService>(() =>
            new UserService(repositoryManager, loggerManager, mapper));*/
            _authenticationService = new Lazy<IAuthenticationService>(() =>
            new AuthenticationService(loggerManager, mapper, userManager, configuration));
        }

        public IBookCategoryService BookCategoryService => _bookCategoryService.Value;
        public IBookService BookService => _bookService.Value;
        public IDonationService DonationService => _donationService.Value;
      /*  public IUserService UserService => _userService.Value;*/
        public IAuthenticationService AuthenticationService => _authenticationService.Value;
    }
}
