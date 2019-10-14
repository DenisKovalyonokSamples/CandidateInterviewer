using DK.Core.Base;
using DK.Core.Interfaces;
using DK.DataAccess.Enums;

namespace DK.DataAccess.Entities
{
    public class Response : BaseEntity, IAggregateRoot
    {
        public int InterviewId { get; set; }
        public int QuestionId { get; set; }

        public string Value { get; set; }
        public bool IsApproved { get; set; }
        public ApprovalType ApprovalType { get; set; }

        public Interview Interview { get; set; }
        public Question Question { get; set; }
    }
}
