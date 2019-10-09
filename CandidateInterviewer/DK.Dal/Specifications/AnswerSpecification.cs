using DK.Core.Base;
using DK.DataAccess.Entities;

namespace DK.DataAccess.Specifications
{
    public sealed class AnswerSpecification : BaseSpecification<Answer>
    {
        public AnswerSpecification(int questionId)
            : base(e => e.QuestionId == questionId)
        {
        }
    }
}
