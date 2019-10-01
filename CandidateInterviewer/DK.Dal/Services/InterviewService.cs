using DK.Core.Interfaces;
using DK.DataAccess.Entities;
using DK.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace DK.DataAccess.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Exam> _examRepository;
        private readonly IAsyncRepository<Question> _questionRepository;
        private readonly IAsyncRepository<Interview> _interviewRepository;

        public InterviewService(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Exam> examRepository, 
            IAsyncRepository<Interview> interviewRepository, IAsyncRepository<Question> questionRepository)
        {
            _categoryRepository = categoryRepository;
            _examRepository = examRepository;
            _interviewRepository = interviewRepository;
            _questionRepository = questionRepository;
        }

        #region Categories

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var entities = await _categoryRepository.ListAllAsync();

            return entities;
        }

        #endregion
    }
}
