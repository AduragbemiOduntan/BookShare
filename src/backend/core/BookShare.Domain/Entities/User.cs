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
        public string? UserFirstName { get; set; }

        public string? UserLastName { get; set; }

        //Nav Property
        public ICollection<Donation>? Donation { get; set; }
    }
}
