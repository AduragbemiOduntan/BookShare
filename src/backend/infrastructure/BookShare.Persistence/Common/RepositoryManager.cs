using BookShare.Appliation.common;
using BookShare.Appliation.contracts;
using BookShare.Domain.Entities;
using BookShare.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Common
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly  Lazy<IBookCategoryRepository> _bookCategoryRepository;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IDonationRepository> _donationRepository;
        private readonly Lazy<IUserRepository> _userRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _bookCategoryRepository = new Lazy<IBookCategoryRepository>(() => new BookCategoryRepository(repositoryContext));
            _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
            _donationRepository = new Lazy<IDonationRepository>(() => new DonationRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(repositoryContext));
        }

        public IBookCategoryRepository BookCategoryRepository => _bookCategoryRepository.Value;
        public IBookRepository BookRepository => _bookRepository.Value;
        public IDonationRepository DonationRepository => _donationRepository.Value;
        public IUserRepository UserRepository => _userRepository.Value;

        public async Task SaveAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }
    }
}
