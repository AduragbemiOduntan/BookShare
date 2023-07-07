using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.contracts
{
    public interface IUserRepository 
    {
        void CreateUser(User user);
        Task<ICollection<User>> GetAllUser();
        Task<User> GetUserByEmail(string userEmail);
        /*Task UpdateUser(int userId, User user);*/
        void DeleteUser(User user);
    }
}
