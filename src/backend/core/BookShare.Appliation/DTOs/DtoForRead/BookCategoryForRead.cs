using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForRead
{
    public class BookCategoryForRead
    {
        public int BookCategoryId { get; set; }

        public string? BookCategoryName { get; set; }

        public string? BookCategoryDescription { get; set; }
    }
}
