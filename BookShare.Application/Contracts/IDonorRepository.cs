using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Contracts
{
    public interface IDonorRepository
    {
        Task<IEnumerable<Donor>> GetAllDonorAsync(bool trackChanges);
        Task<Donor> GetDonorByDonorIdAsync(int donorId, bool trackChanges);
        void CreateDonor(Donor donor);
        void DeleteDonor(Donor donor);
    }
}
