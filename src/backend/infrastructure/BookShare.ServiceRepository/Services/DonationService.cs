using AutoMapper;
using BookShare.Appliation.common;
using BookShare.Appliation.DTOs.DtoForCreate;
using BookShare.Appliation.DTOs.DtoForRead;
using BookShare.ServiceRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.ServiceRepository.Services
{
    internal sealed class DonationService : IDonationService
    {
        private IRepositoryManager _repsositoryManager;
        private ILoggerManager _loggerManager;
        private IMapper _mapper;

        public DonationService(IRepositoryManager repositoryManager, ILoggerManager logerManager, IMapper mapper)
        {
            _repsositoryManager = repositoryManager;
            _loggerManager = logerManager;
            _mapper = mapper;
        }

        public Task<DonationForCreation> CreateDonationAsync(DonationForCreation donationForCreation)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDonationAsynnc(string donationId)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<DonationForRead>> GetAllDonationsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<DonationForRead> GetDonationByIdAsync(string donationId)
        {
            throw new NotImplementedException();
        }
    }
}
