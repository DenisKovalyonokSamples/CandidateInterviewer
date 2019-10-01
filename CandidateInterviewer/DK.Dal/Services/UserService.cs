using DK.Core.Interfaces;
using DK.DataAccess.Entities;
using DK.DataAccess.Interfaces;

namespace DK.DataAccess.Services
{
    public class UserService : IUserService
    {
        private readonly IAsyncRepository<Candidate> _candidateRepository;

        public UserService(IAsyncRepository<Candidate> candidateRepository)
        {
            _candidateRepository = candidateRepository;
        }

        //TODO: Add public methods
    }
}
