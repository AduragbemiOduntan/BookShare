using BookShare.Appliation.contracts;
using BookShare.Domain.Entities;
using BookShare.Persistence.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Persistence.Repositories
{
    public class DonationRepository : RepositoryBase<Donation>, IDonationRepository
    {
        public DonationRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public void CreateDonation(Donation donation)
        {
            Create(donation);
        }

        public void DeleteDonation(Donation donation)
        {
            Delete(donation);
        }

        public async Task<ICollection<Donation>> GetAllDonation()
        {
            return await FindAll().OrderBy(x => x.Id).ToListAsync();
        }

        public async Task<Donation> GetDonationById(string donationId)
        {
            return await FindByCondition(x => x.Id == donationId).FirstOrDefaultAsync();
        }
    }
}
