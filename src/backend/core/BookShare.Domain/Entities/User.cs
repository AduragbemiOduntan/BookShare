using BookShare.Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public class User : IdentityUser
    {
        [Required(ErrorMessage = "The First Name field is required.")]
        public string? UserFirstName { get; set; }

        [Required(ErrorMessage = "The Last Name field is required.")]
        public string? UserLastName { get; set; }

        //Nav Properties
        public ICollection<Donation>? Donation { get; set; }
    }
}
