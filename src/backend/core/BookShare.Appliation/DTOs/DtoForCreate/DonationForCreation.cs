using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.DTOs.DtoForCreate
{
    public class DonationForCreation
    {
        public string? BookCondition { get; set; }

        public int NumberOfBoxes { get; set; }
    }
}
