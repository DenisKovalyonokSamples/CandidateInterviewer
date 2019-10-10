using DK.DataAccess.Enums;

namespace DK.Web.ViewModels
{
    public class CompleteViewModel
    {
        public int InterviewId { get; set; }

        public string CandidateName { get; set; }

        public string CandidateDescription { get; set; }

        public string ExamTypeLogo { get; set; }

        public string ExamLogo { get; set; }

        public ExamType Type { get; set; }

        public string Score { get; set; }
    }
}
