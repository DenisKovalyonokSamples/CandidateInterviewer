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
        Task<Exam> GeExamAsync(int id);
    }
}
