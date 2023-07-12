﻿using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
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
        Task<UserForRead> GetUserByIdAsync(int userId);
        Task<UserForCreation> CreateUserAsync(UserForCreation userForCreation);
        Task UpdateUserAsync(int userId, UserForUpdate userForUpdate);
        Task DeleteUserAsynnc(int userId);
    }  
}
