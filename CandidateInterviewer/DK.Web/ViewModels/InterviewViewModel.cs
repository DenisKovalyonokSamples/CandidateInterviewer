using DK.DataAccess.Enums;

namespace DK.Web.ViewModels
{
    public class InterviewViewModel
    {
        public CategoryViewModel Category { get; set; }

        public CandidateViewModel Candidate { get; set; }

        public ExamType SelectedExamType { get; set; }
    }
}
