using DK.DataAccess.Entities;
using System.Threading.Tasks;

namespace DK.DataAccess.Interfaces
{
    public interface IUserService
    {
        Task<Candidate> InitCandidateAsync(Candidate entity);
    }
}
