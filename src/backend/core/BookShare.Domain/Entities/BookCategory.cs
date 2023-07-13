﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Entities
{
    public class BookCategory
    {
        [Key]
        public string? BookCategoryId { get; set; }
      
        public string? BookCategoryName { get; set; }
       
        public string? BookCategoryDescription { get; set; }

        //Nav Property
        public ICollection<Book>? Book { get; set; }
    }
}
