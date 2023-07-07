﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BookShare.Domain.Common;

namespace BookShare.Domain.Entities
{
    public class Book : BaseEntity
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(100, ErrorMessage = "Title should not exceed 100 characters")]
        [Required(ErrorMessage = "The Title field is required.")]
        public string? Title { get; set; }

        [MaxLength(100, ErrorMessage = " Author not exceed 100 characters")]
        [Required(ErrorMessage = "The Author field is required.")]
        public string? Author { get; set; }

        [Required(ErrorMessage = "The Category Code field is required.")]
        [ForeignKey(nameof(BookCategory))]
        public string? BookCategoryName { get; set; }

        [MaxLength(20, ErrorMessage = "ISBN should not exceed 20 characters")]
        [Required(ErrorMessage = "The ISBN field is required.")]
        [Display(Name = "ISBN")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "The Quantity field is required.")]
        [Range(5, int.MaxValue, ErrorMessage = "The Quantity field must be a non-negative value.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The Publication Date field is required.")]
        public DateTime PublicationDate { get; set; }

        [Required(ErrorMessage = "The Box Number field is required.")]
        
        public int BoxNumber { get; set; }

      /*  [Url]
        public string BookImageUrl { get; set; }*/

        public ICollection<Donation>? Donation { get; set; }
        public BookCategory? BookCategory { get; set; }
    }
}
