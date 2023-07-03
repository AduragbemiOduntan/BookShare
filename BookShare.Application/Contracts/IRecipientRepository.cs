using BookShare.Domain.Entities;

namespace BookShare.Application.Contracts
{
    public interface IRecipientRepository
    {
        Task<IEnumerable<Recipient>> GetAllRecipientAsync(bool trackChanges);
        Task<Recipient> GetRecipientByRecipientIdAsync(int Id, bool trackChanges);
        void CreateRecipient(Recipient recipient);
        void DeleteRecipient(Recipient recipient);
    }
}
