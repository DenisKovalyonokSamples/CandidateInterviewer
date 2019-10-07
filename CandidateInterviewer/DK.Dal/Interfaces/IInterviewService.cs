using DK.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DK.DataAccess.Interfaces
{
    public interface IInterviewService
    {
        Task<Category> GetCategoryAsync(int id);
        Task<List<Category>> GetCategoriesAsync();
    }
}
