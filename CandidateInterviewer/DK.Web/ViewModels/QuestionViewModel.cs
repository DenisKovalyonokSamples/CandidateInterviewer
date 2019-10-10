using DK.DataAccess.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DK.Web.ViewModels
{
    public class QuestionViewModel
    {
        public int Id { get; set; }

        public int ExamId { get; set; }

        public string Title { get; set; }

        public string Notes { get; set; }

        public AnswerType Type { get; set; }

        public int Score { get; set; }

        [Required(ErrorMessage = "Please enter your answer.")]
        public string CandidateAnswer { get; set; }

        public List<AnswerViewModel> Answers { get; set; }
    }
}
