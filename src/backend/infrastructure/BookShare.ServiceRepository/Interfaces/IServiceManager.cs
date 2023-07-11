using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Interfaces
{
    public interface IServiceManager
    {
        IBookCategoryService BookCategoryService { get; }
        IBookService BookService { get; }
        IDonationService DonationService { get; }
        IUserService UserService { get; }
    }
}
