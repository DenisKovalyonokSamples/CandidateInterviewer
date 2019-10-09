using DK.Core.Base;
using DK.DataAccess.Entities;

namespace DK.DataAccess.Specifications
{
    public sealed class QuestionSpecification : BaseSpecification<Question>
    {
        public QuestionSpecification(int examId)
            : base(e => e.ExamId == examId)
        {
        }
    }
}
