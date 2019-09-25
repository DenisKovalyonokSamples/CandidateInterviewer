using DK.Core.Base;
using DK.Core.Interfaces;
using DK.DataAccess.Enums;

namespace DK.DataAccess.Entities
{
    public class Question : BaseEntity, IAggregateRoot
    {
        public int ExamId { get; set; }

        public string Title { get; set; }
        public string Notes { get; set; }
        public AnswerType Type { get; set; }

        public Exam Exam { get; set; }
    }
}
