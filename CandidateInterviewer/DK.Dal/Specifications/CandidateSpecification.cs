using DK.Core.Base;
using DK.DataAccess.Entities;

namespace DK.DataAccess.Specifications
{
    public sealed class CandidateSpecification : BaseSpecification<Candidate>
    {
        public CandidateSpecification(string email)
            : base(e => e.Email == email)
        {
        }
    }
}
