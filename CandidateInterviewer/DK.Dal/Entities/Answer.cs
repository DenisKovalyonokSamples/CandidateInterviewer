using DK.Core.Base;
using DK.Core.Interfaces;

namespace DK.DataAccess.Entities
{
    public class Answer : BaseEntity, IAggregateRoot
    {
        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }
        public string Value { get; set; }

        public virtual Question Question { get; set; }
    }
}
