using DK.Dal.Entities.Base;
using System;

namespace DK.Dal.Entities
{
    public class Interview : BaseEntity
    {
        public int CandidateId { get; set; }
        public int ExamId { get; set; }

        public string Score { get; set; }
        public DateTime Date { get; set; }

        public Candidate Candidate { get; set; }
        public Exam Exam { get; set; }
    }
}
