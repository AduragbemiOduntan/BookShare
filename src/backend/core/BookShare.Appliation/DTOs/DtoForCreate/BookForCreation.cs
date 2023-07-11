using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BookShare.Appliation.DTOs.DtoForCreate
{
    public class BookForCreation
    {
        [MaxLength(100, ErrorMessage = "Title should not exceed 100 characters")]
        [Required(ErrorMessage = "The Title field is required.")]
        public string? Title { get; set; }

        [MaxLength(100, ErrorMessage = " Author not exceed 100 characters")]
        [Required(ErrorMessage = "The Author field is required.")]
        public string? Author { get; set; }

        [MaxLength(20, ErrorMessage = "ISBN should not exceed 20 characters")]
        [Required(ErrorMessage = "The ISBN field is required.")]
        [Display(Name = "ISBN")]
        public string? ISBN { get; set; }

        [Required(ErrorMessage = "The Quantity field is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "The Quantity field must be a non-negative value.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "The Publication Date field is required.")]
        [DataType(DataType.DateTime)]
        public DateTime PublicationDate { get; set; }
    }
}
