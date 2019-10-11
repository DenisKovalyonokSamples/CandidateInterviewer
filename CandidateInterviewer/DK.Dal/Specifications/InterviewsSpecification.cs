using DK.Core.Base;
using DK.DataAccess.Entities;
using System;

namespace DK.DataAccess.Specifications
{
    public class InterviewsSpecification : BaseSpecification<Interview>
    {
        public InterviewsSpecification()
            : base(e => Convert.ToInt32(e.Score) > 0)
        {
        }
    }
}
