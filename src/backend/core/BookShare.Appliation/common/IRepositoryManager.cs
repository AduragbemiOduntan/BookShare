using BookShare.Appliation.contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.common
{
    public interface IRepositoryManager
    {
         IBookCategoryRepository BookCategoryRepository { get; }
         IBookRepository BookRepository { get; }
         IDonationRepository DonationRepository { get; }
         IUserRepository UserRepository { get; }

         Task SaveAsync();
    }
}