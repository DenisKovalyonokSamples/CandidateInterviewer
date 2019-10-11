using DK.DataAccess.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DK.DataAccess.Interfaces
{
    public interface IUserService
    {
        Task<Candidate> InitCandidateAsync(Candidate entity);
        Task<Candidate> GetCandidateAsync(int id);
        Task<List<Candidate>> GetCandidatesAsync();
    }
}
