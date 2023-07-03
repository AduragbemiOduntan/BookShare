using BookShare.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public class Book : BaseEntity
    {
        public int BookId { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        public string?Title { get; set; }

        [Required(ErrorMessage = "The Author field is required.")]
        public string? Auhor { get; set; }

        [Required(ErrorMessage = "The Description field is required.")]
        public string? Desciption { get; set; }

        [Required(ErrorMessage = "The ISBN field is required.")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "The Price field is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "The Price field must be a positive value.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Quantity field is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "The Quantity field must be a non-negative value.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The Publication Date field is required.")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "The CategoryId field is required.")]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }

        public ICollection<Donation>? Donations { get; set;}
       
    }
}
