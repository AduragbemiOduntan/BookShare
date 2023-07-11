﻿using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using BookShare.Domain.Entities;
using BookShare.ServiceRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    internal sealed class UserService : IUserService
    {
        private IRepositoryManager _repsositoryManager;
        private ILoggerManager _loggerManager;
        private IMapper _mapper;

        public UserService(IRepositoryManager repositoryManager, ILoggerManager logerManager, IMapper mapper)
        {
            _repsositoryManager = repositoryManager;
            _loggerManager = logerManager; 
            _mapper = mapper;
        }

        public async Task<UserForCreation> CreateUserAsync(UserForCreation userForCreation)
        {
            var userEntity =  _mapper.Map<User>(userForCreation);

            _repsositoryManager.UserRepository.CreateUser(userEntity);
            await _repsositoryManager.SaveAsync();

            var userToReturn = _mapper.Map<UserForCreation>(userEntity);
            return userToReturn;
        }

        public async Task DeleteUserAsynnc(string userEmail)
        {
            var getUserEntiry = await _repsositoryManager.UserRepository.GetUserByEmail(userEmail);

            _repsositoryManager.UserRepository.DeleteUser(getUserEntiry);

            _repsositoryManager.SaveAsync();
        }

        public async Task<ICollection<UserForRead>> GetAllUsersAsync()
        {
            var getAllUserEntities = await _repsositoryManager.UserRepository.GetAllUser();

            var userEntities = _mapper.Map<ICollection<UserForRead>>(getAllUserEntities);
            return userEntities;
        }

        public async Task<UserForRead> GetUserByEmailAsync(string userEmail)
        {
            var getUserEntity = await _repsositoryManager.UserRepository.GetUserByEmail(userEmail);

            var userEntity = _mapper.Map<UserForRead>(getUserEntity); 
            return userEntity;  
        }

        public async Task UpdateUserAsync(string userEmail, UserForUpdate userForUpdate)
        {
            var getUserEntity = await _repsositoryManager.UserRepository.GetUserByEmail(userEmail);

            _mapper.Map(userForUpdate, getUserEntity);

            await _repsositoryManager.SaveAsync();
        }
    }
}
