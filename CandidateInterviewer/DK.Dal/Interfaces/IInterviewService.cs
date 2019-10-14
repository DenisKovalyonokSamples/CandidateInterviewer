using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DK.DataAccess.Interfaces
{
    public interface IInterviewService
    {
        Task<Category> GetCategoryAsync(int id);
        Task<List<Category>> GetCategoriesAsync();
        Task<Exam> GetExamByCategoryAsync(int categoryId, ExamType type);
        Task<Interview> InitInterviewAsync(int candidateId, int examId);
        Task<Interview> GetInterviewAsync(int id);
        Task<Exam> GetExamAsync(int id);
        Task<List<Question>> GetQuestionsForExamAsync(int examId);
        Task<Question> GetQuestionAsync(int id);
        Task<List<Answer>> GetAnswersForQuestionAsync(int questionId);
        Task<Answer> GetAnswerAsync(int id);
        Task<bool> UpdateInterviewScoreAsync(Interview entity, int score);
        Task<List<Interview>> GetPassedInterviewsAsync();
        Task<List<Response>> GetResponsesForInterviewAsync(int interviewId);
        Task SaveResponcesForInterviewAsync(List<Response> entities);
        Task<Response> GetResponseAsync(int id);
    }
}
