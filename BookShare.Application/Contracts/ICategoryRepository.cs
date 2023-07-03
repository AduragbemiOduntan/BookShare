using BookShare.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Application.Contracts
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllCategoryAsync(bool trackChanges);
        Task<Category> GetCategoryByIdAsync(int CategoryId, bool trackChanges);
        void CreateCategory(Category category);
        void DeleteCategory(Category category);
    }
}
