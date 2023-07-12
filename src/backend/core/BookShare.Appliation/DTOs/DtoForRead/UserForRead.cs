using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForRead
{
    public class UserForRead
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        public string? UserFirstName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        public string? UserLastName { get; set; }

        public string? UserName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [DataType(DataType.EmailAddress)]
        public string? UserEmail { get; set; }

        [Required(ErrorMessage = "The Password field is required.")]
        [DataType(DataType.Password)]
        public string? UserPassword { get; set; }

        [Required(ErrorMessage = "PhoneNumber field is required.")]
        [DataType(DataType.PhoneNumber)]
        public string? UserPhoneNumber { get; set; }
    }
}
