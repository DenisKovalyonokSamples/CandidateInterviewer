using DK.Dal.Entities.Base;
using DK.Dal.Enums;

namespace DK.Dal.Entities
{
    public class Question : BaseEntity
    {
        public int InterviewId { get; set; }

        public string Title { get; set; }
        public string Notes { get; set; }
        public AnswerType Type { get; set; }

        public Interview Interview { get; set; }
    }
}
