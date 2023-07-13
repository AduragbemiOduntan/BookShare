using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Appliation.contracts
{
    public interface IDonationRepository
    {
        void CreateDonation(Donation donation);
        Task<ICollection<Donation>> GetAllDonation();
        Task<Donation> GetDonationById(string donationId);
        /*Task Update(int donationId, Donation donation);*/
        void DeleteDonation(Donation donation);
    }
}
