using BookShare.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public  class Donor : BaseEntity
    {
        [Key]
        public int DonorId { get; set; }

        [Required]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Address { get; set; }

        //Relationships
        public ICollection<Donation>? Donations { get; set; }
    }
}
