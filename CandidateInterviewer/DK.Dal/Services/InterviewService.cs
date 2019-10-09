using DK.Core.Interfaces;
using DK.DataAccess.Entities;
using DK.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using DK.DataAccess.Enums;
using DK.DataAccess.Specifications;
using System;

namespace DK.DataAccess.Services
{
    public class InterviewService : IInterviewService
    {
        private readonly IAsyncRepository<Category> _categoryRepository;
        private readonly IAsyncRepository<Exam> _examRepository;
        private readonly IAsyncRepository<Question> _questionRepository;
        private readonly IAsyncRepository<Interview> _interviewRepository;
        private readonly IAsyncRepository<Answer> _answerRepository;
        private readonly ILogService<UserService> _logger;

        public InterviewService(IAsyncRepository<Category> categoryRepository, IAsyncRepository<Exam> examRepository, 
            IAsyncRepository<Interview> interviewRepository, IAsyncRepository<Question> questionRepository,
            IAsyncRepository<Answer> answerRepository, ILogService<UserService> logger)
        {
            _categoryRepository = categoryRepository;
            _examRepository = examRepository;
            _interviewRepository = interviewRepository;
            _questionRepository = questionRepository;
            _answerRepository = answerRepository;
            _logger = logger;
        }

        #region Categories

        public async Task<Category> GetCategoryAsync(int id)
        {
            var entity = await _categoryRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            var entities = await _categoryRepository.ListAllAsync();

            return entities;
        }

        #endregion

        #region Interview

        public async Task<Interview> InitInterviewAsync(int candidateId, int examId)
        {
            var entity = new Interview();
            entity.CandidateId = candidateId;
            entity.ExamId = examId;
            entity.Date = DateTime.UtcNow;
            entity.Score = "0";

            return await _interviewRepository.AddAsync(entity);
        }

        public async Task<Interview> GetInterviewAsync(int id)
        {
            var entity = await _interviewRepository.GetByIdAsync(id);

            return entity;
        }

        #endregion

        #region Exam

        public async Task<Exam> GetExamByCategoryAsync(int categoryId, ExamType type)
        {
            var examSpec = new ExamSpecification(categoryId, type);
            var entity = (await _examRepository.ListAsync(examSpec)).FirstOrDefault();

            if (entity == null)
            {
                _logger.LogInformation($"Exam for category {categoryId} was not found.");
            }

            return entity;
        }

        public async Task<Exam> GetExamAsync(int id)
        {
            var entity = await _examRepository.GetByIdAsync(id);

            return entity;
        }

        #endregion

        #region Question

        public async Task<List<Question>> GetQuestionsForExamAsync(int examId)
        {
            var questionSpec = new QuestionSpecification(examId);
            var entities = (await _questionRepository.ListAsync(questionSpec))?.ToList();

            if (entities == null)
            {
                _logger.LogInformation($"Questions for exam {examId} were not found.");
            }

            return entities;
        }

        public async Task<Question> GetQuestionAsync(int id)
        {
            var entity = await _questionRepository.GetByIdAsync(id);

            return entity;
        }

        #endregion

        #region Answer

        public async Task<List<Answer>> GetAnswersForQuestionAsync(int questionId)
        {
            var answerSpec = new AnswerSpecification(questionId);
            var entities = (await _answerRepository.ListAsync(answerSpec))?.ToList();

            if (entities == null)
            {
                _logger.LogInformation($"Answers for question {questionId} were not found.");
            }

            return entities;
        }

        public async Task<Answer> GetAnswerAsync(int id)
        {
            var entity = await _answerRepository.GetByIdAsync(id);

            return entity;
        }

        #endregion
    }
}
