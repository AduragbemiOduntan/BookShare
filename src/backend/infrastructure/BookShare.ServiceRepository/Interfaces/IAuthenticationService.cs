using BookShare.Appliation.DTOs;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Interfaces
{
    public interface IAuthenticationService
    {
        Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration);
    }
}
