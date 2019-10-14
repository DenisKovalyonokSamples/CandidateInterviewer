using DK.DataAccess.Enums;
using System.Collections.Generic;

namespace DK.Web.ViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }

        public int CandidateId { get; set; }

        public int InterviewId { get; set; }

        public string Name { get; set; }

        public string Logo { get; set; }

        public string Description { get; set; }

        public ExamType Type { get; set; }

        public string TypeLogo { get; set; }

        public string CandidateFullName { get; set; }

        public string CandidateDescription { get; set; }

        public string CandidateEmail { get; set; }

        public string CandidatePhone { get; set; }

        public List<QuestionViewModel> Questions { get; set; }

        public List<ResponseViewModel> Responses { get; set; }
    }
}
