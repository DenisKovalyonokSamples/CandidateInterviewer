using DK.DataAccess.Entities.Base;
using DK.DataAccess.Enums;

namespace DK.DataAccess.Entities
{
    public class Question : BaseEntity
    {
        public int ExamId { get; set; }

        public string Title { get; set; }
        public string Notes { get; set; }
        public AnswerType Type { get; set; }

        public Exam Exam { get; set; }
    }
}
