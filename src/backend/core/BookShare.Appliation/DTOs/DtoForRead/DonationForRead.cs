using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForRead
{
    public class DonationForRead
    {
        public int Quantity { get; set; }

        public string? BookCondition { get; set; }

        public int NumberOfBoxes { get; set; }
    }
}
