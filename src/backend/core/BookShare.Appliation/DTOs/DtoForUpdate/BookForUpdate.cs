using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForUpdate
{
    public class BookForUpdate
    {
        public string? Id { get; set; }

        [Required(ErrorMessage = "The Quantity field is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "The Quantity field must be a non-negative value.")]
        public int Quantity { get; set; }
    }
}