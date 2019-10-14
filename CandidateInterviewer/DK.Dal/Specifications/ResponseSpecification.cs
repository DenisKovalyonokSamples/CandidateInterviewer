using DK.Core.Base;
using DK.DataAccess.Entities;

namespace DK.DataAccess.Specifications
{
    public sealed class ResponseSpecification : BaseSpecification<Response>
    {
        public ResponseSpecification(int interviewId)
            : base(e => e.InterviewId == interviewId)
        {
        }
    }
}
