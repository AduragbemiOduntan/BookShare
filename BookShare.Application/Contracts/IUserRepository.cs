using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Entities;
namespace BookShare.Application.Contracts
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUserAsync(bool trackChanges);
        Task<User> GetUserByUserIdAsync(int UserId, bool trackChanges);
        void CreateUser(User user);
        void DeleteUser(User user);
    }
}
