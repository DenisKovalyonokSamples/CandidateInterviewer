using DK.Core.Base;
using DK.Core.Interfaces;
using System;

namespace DK.DataAccess.Entities
{
    public class Interview : BaseEntity, IAggregateRoot
    {
        public int CandidateId { get; set; }
        public int ExamId { get; set; }

        public string Score { get; set; }
        public DateTime Date { get; set; }

        public Candidate Candidate { get; set; }
        public Exam Exam { get; set; }
    }
}
