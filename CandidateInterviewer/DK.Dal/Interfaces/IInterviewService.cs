using DK.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DK.DataAccess.Interfaces
{
    public interface IInterviewService
    {
        Task<List<Category>> GetCategoriesAsync();
    }
}
