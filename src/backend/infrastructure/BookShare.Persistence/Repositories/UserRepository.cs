using BookShare.Appliation.contracts;
using BookShare.Domain.Entities;
using BookShare.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateUser(User user)
        {
            Create(user);
        }

        public void DeleteUser(User user)
        {
            Delete(user);
        }

        public async Task<ICollection<User>> GetAllUser()
        {
            return await FindAll().OrderBy(x => x.Id).ToListAsync();
        }

      /*  public async Task<User> GetUserByEmail(string userEmail)
        {
            return await FindByCondition(x => x.UserEmail == userEmail).FirstOrDefaultAsync();
        }*/

        public async Task<User> GetUserById(string userId)
        {
            return await FindByCondition(x => x.Id == userId).FirstOrDefaultAsync();
        }
    }
}
