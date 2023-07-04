using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Common
{
    public sealed class RepositoryManager : IRepositoryManager
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly Lazy<IBookRepository> _bookRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IDonationRepository> _DonationRepository;
        private readonly Lazy<IDonorRepository> _DonorRepository;
        private readonly Lazy<IRecipientRepository> _RecipientRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;

        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
            _bookRepository = new Lazy<IBookRepository>(() = new BookRepository(repositoryContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() = new CategoryRepository(repositoryContext));
            _DonationRepository = new Lazy<IDonationRepository>(() = new DonationRepository(repositoryContext));
            _DonorRepository = new Lazy<IDonorRepository>(() = new DonorRepository(repositoryContext));
            _RecipientRepository = new Lazy<IRecipientRepository>(() = new RecipientRepository(repositoryContext));
            _userRepository = new Lazy<IUserRepository> (()= new UserRepository(repositoryContext));

        }


    }
}
