using BookShare.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public class User : BaseEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "The First Name field is required.")]
        public string? UserFirstName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        public string? UserLastName { get; set; }

        public string? UserName { get; set; }

        [Required(ErrorMessage = "The Email field is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string? UserEmail { get; set; }

        [Required(ErrorMessage = "The Password field is required.")]
        public string? UserPassword { get; set; }

        [Required(ErrorMessage = "PhoneNumber field is required.")]
        [Phone(ErrorMessage = "Invalid PhoneNumber.")]
        public string? UserPhoneNumber { get; set; }

        //Nav Properties
        public ICollection<Donation>? Donation { get; set; }
    }
}
