using BookShare.Appliation.DTOs;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Interfaces
{
    public interface IUserService
    {
        Task<ICollection<UserForRead>> GetAllUsersAsync();
        /*Task<UserForRead> GetUserByEmailAsync(string userEmail);*/
        Task<UserForRead> GetUserByIdAsync(string userId);
        Task<UserForCreation> CreateUserAsync(UserForCreation userForCreation);
        /*Task<UserForRegistrationDto> CreateUserAsync(UserForRegistrationDto userForRegistration);*/
        Task UpdateUserAsync(string userId, UserForUpdate userForUpdate);
        Task DeleteUserAsynnc(string userId);
    }  
}
