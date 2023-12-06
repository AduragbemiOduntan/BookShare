using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Appliation.DTOs;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Domain.Entities;
using BookShare.ServiceRepository.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    internal sealed class AuthenticationService : IAuthenticationService
    {
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        private readonly UserManager<User> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IEmailService _emailService;

        public AuthenticationService(ILoggerManager logger, IMapper mapper, UserManager<User> userManager, IConfiguration configuration, IEmailService emailService)
        {
            _logger = logger;
            _mapper = mapper;
            _userManager = userManager;
            _configuration = configuration;
            _emailService = emailService;
        }
        public void SendContactMessage(ContactUs contact)
        {
            string toAddress = "healthtechnigerialimited@gmail.com"; // Replace with your contact email address
            string ToAddress = contact.Email;
            string subject = "BookShare";
            string Body = $"Thank you for reaching out to us, your message has been received,please kindly hold on as we get back to you";
            string body = $" {contact.Name} with Email {contact.Email} sent a message please kindly reply<br> Message content. <br> ({contact.Message})";
           
            try
            {
                _emailService.SendEmail(ToAddress, subject, Body);
                _emailService.SendEmail(toAddress, subject, body);
                 

            }
            catch (Exception ex)
            {
                // Handle any errors (log, throw, etc.)
                throw new Exception("An error occurred while sending the message.", ex);
            }
        }
        public async Task<IdentityResult> RegisterUser(UserForRegistrationDto userForRegistration)
        {
            var user = _mapper.Map<User>(userForRegistration);
            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (result.Succeeded)
                await _userManager.AddToRolesAsync(user, userForRegistration.Roles);
            return result;
        }
    }
}
