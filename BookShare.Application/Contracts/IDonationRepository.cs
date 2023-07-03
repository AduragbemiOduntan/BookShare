using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Contracts
{
    public interface IDonationRepository
    {
        Task<IEnumerable<Donation>> GetAllDonationAsync(bool trackChanges);
        Task<Donation> GetDonationByDonationIdAsync(int addressId, bool trackChanges);
        void CreateDonation(Donation donation);
        void DeleteDonation(Donation donation);
    }
}
