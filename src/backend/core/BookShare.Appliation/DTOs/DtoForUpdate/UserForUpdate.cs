using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForUpdate
{
    public class UserForUpdate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [DataType(DataType.EmailAddress)]
        public string? UserEmail { get; set; }

        [Required(ErrorMessage = "PhoneNumber field is required.")]
        [DataType(DataType.PhoneNumber)]
        public string? UserPhoneNumber { get; set; }
    }
}
