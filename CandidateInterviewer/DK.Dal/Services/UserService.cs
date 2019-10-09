using DK.Core.Interfaces;
using DK.DataAccess.Entities;
using DK.DataAccess.Interfaces;
using DK.DataAccess.Specifications;
using System.Threading.Tasks;
using System.Linq;

namespace DK.DataAccess.Services
{
    public class UserService : IUserService
    {
        private readonly IAsyncRepository<Candidate> _candidateRepository;
        private readonly ILogService<UserService> _logger;

        public UserService(IAsyncRepository<Candidate> candidateRepository, ILogService<UserService> logger)
        {
            _candidateRepository = candidateRepository;
            _logger = logger;
        }

        public async Task<Candidate> GetCandidateAsync(int id)
        {
            var entity = await _candidateRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<Candidate> InitCandidateAsync(Candidate entity)
        {
            if (entity == null)
            {
                _logger.LogInformation($"Candidate info is empty.");

                return null;
            }

            var candidateSpec = new CandidateSpecification(entity.Email);
            var candidate = (await _candidateRepository.ListAsync(candidateSpec)).FirstOrDefault();

            if (candidate == null)
            {
                return await _candidateRepository.AddAsync(entity);
            }
            else
            {
                candidate.FirstName = entity.FirstName;
                candidate.LastName = entity.LastName;
                candidate.Email = entity.Email;
                candidate.Phone = entity.Phone;
                candidate.Skype = entity.Skype;
                candidate.Description = entity.Description;

                await _candidateRepository.UpdateAsync(candidate);
                return candidate;
            }
        }
    }
}
