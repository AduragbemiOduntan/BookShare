using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.Appliation.DTOs.DtoForUpdate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Interfaces
{
    public interface IDonationService
    {
        Task<ICollection<DonationForRead>> GetAllDonationsAsync();
        Task<DonationForRead> GetDonationByIdAsync(string donationId);
        Task<DonationForCreation> CreateDonationAsync(DonationForCreation donationForCreation);
        Task DeleteDonationAsynnc(string donationId);
    }
}
