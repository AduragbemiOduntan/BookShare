using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
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

        [ForeignKey(nameof(User))]
        public int UserId { get; set; }

        public int Quantity { get; set; }

        public string? BookCondition { get; set; }

        public int NumberOfBoxes { get; set; }

        public DateTime DonationDate { get; set; } = DateTime.Now;

        //Navition Property
        public User? User { get; set; }
        public ICollection<Book>? Book { get; set; }
    }
}
