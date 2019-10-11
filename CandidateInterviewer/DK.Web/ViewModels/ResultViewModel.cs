using DK.DataAccess.Enums;
using System;

namespace DK.Web.ViewModels
{
    public class ResultViewModel
    {
        public int InterviewId { get; set; }

        public string CandidateFullName { get; set; }

        public string CandidateDescription { get; set; }   

        public string ExamName { get; set; }

        public ExamType Type { get; set; }

        public string Email { get; set; }

        public int Score { get; set; }

        public string ExamTypeLogo { get; set; }

        public string ExamLogo { get; set; }

        public DateTime Date { get; set; }
    }
}
