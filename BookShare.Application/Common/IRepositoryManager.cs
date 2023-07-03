using BookShare.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Common
{
    public  interface IRepositoryManager
    {
        IBookRepository bookRepository { get; }
        IUserRepository userRepository { get; }
        IDonationRepository onationRepository { get; }
        IDonorRepository DonorRepository { get; }
        IRecipientRepository recipientRepository { get; }
        ICategoryRepository categoryRepository { get; }

        Task SaveAsync();
        

        
    }
}
