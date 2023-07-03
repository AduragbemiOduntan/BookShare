using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShare.Domain.Common;

namespace BookShare.Domain.Entities
{
    public class Donation : BaseEntity
    {
        [Key]
        public int DonationId { get; set; }

        [Required]
        public int BookId { get; set; }

        [ForeignKey("BookId")]
        public Book? Book { get; set; }

        [Required]
        public int DonorId { get; set; }

        [ForeignKey("DonorId")]
        public Donor? Donor { get; set; }

        public int? RecipientId { get; set; }

        [ForeignKey("RecipientId")]
        public Recipient? Recipient { get; set; }

        [Required]
        public DateTime DonationDate { get; set; }
        public Donor? Donors { get; set; }
        public Recipient? Donations { get; set; }

    
    }
}
