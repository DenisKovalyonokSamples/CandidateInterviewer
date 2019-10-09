namespace DK.Web.ViewModels
{
    public class AnswerViewModel
    {
        public int Id { get; set; }

        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }

        public string Value { get; set; }

        public bool CandidateAnswer { get; set; }
    }
}
