using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using DK.Web.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace DK.Web.Managers
{
    public static class ViewModelBuilder
    {
        public static HomeViewModel GetHomeViewModel(List<Category> entities)
        {
            var viewModel = new HomeViewModel();

            if (entities?.Any() == true)
            {
                viewModel.Categories = entities?
                  .Select(o => new CategoryViewModel()
                  {
                      Id = o.Id,
                      Name = o.Name,
                      Description = o.Description,
                      Logo = o.Logo
                  })?.ToList() ?? new List<CategoryViewModel>();
            }

            return viewModel;
        }

        public static InterviewsViewModel GetInterviewsViewModel(List<Category> entities)
        {
            var viewModel = new InterviewsViewModel();

            if (entities?.Any() == true)
            {
                viewModel.Categories = entities?
                  .Select(o => new CategoryViewModel()
                  {
                      Id = o.Id,
                      Name = o.Name,
                      Description = o.Description,
                      Logo = o.Logo,
                      Type = o.Type
                  })?.ToList() ?? new List<CategoryViewModel>();
            }

            return viewModel;
        }

        public static ExamViewModel GetExamViewModel(Interview interview, Exam entitiy, Candidate candidate, List<Question> questions, List<Answer> answers)
        {
            var viewModel = new ExamViewModel();

            viewModel.Id = entitiy.Id;
            viewModel.CategoryId = entitiy.CategoryId;
            viewModel.CandidateId = candidate.Id;
            viewModel.InterviewId = interview.Id;
            viewModel.CandidateFullName = candidate.FirstName + " " + candidate.LastName;
            viewModel.Type = entitiy.Type;
            viewModel.Logo = entitiy.Logo;
            viewModel.Name = entitiy.Name;
            viewModel.Description = entitiy.Description;
            viewModel.TypeLogo = MediaManager.GetIconForExamType(entitiy.Type);
            viewModel.Questions = GetQuestionsForExamViewModel(questions, answers);

            return viewModel;
        }

        public static List<QuestionViewModel> GetQuestionsForExamViewModel(List<Question> questions, List<Answer> answers)
        {
            var viewModel = new List<QuestionViewModel>();

            if (questions?.Any() == true && answers?.Any() == true)
            {
                viewModel = questions.Select(o => new QuestionViewModel()
                {
                    Id = o.Id,
                    ExamId = o.ExamId,
                    Title = o.Title,
                    Type = o.Type,
                    Notes = o.Notes,
                    Score = o.Score,
                    Answers = answers.Where(x => x.QuestionId == o.Id)?.Select(e => new AnswerViewModel()
                    {
                        Id = e.Id,
                        QuestionId = e.QuestionId,
                        IsCorrect = e.IsCorrect,
                        Value = e.Value
                    })?.ToList() ?? new List<AnswerViewModel>()
                })?.ToList() ?? new List<QuestionViewModel>();
            }

            return viewModel;
        }

        public static InterviewViewModel GetInterviewViewModel(Category entitiy)
        {
            var viewModel = new InterviewViewModel();

            viewModel.Candidate = new CandidateViewModel();
            viewModel.Category = GetCategoryViewModel(entitiy);
            viewModel.SelectedExamType = ExamType.Unknown;

            return viewModel;
        }

        public static CompleteViewModel GetCompleteViewModel(Interview interview, Candidate candidate)
        {
            var viewModel = new CompleteViewModel();

            viewModel.InterviewId = interview.Id;
            viewModel.Score = interview.Score;
            viewModel.CandidateName = candidate.FirstName + " " + candidate.LastName;

            return viewModel;
        }

        public static CategoryViewModel GetCategoryViewModel(Category entity)
        {
            var viewModel = new CategoryViewModel();

            if (entity != null)
            {
                viewModel.Id = entity.Id;
                viewModel.Name = entity.Name;
                viewModel.Description = entity.Description;
                viewModel.Logo = entity.Logo;
                viewModel.Type = entity.Type;
            }

            return viewModel;
        }

        public static CandidateViewModel GetCandidateViewModel(Candidate entity)
        {
            var viewModel = new CandidateViewModel();

            if (entity != null)
            {
                viewModel.Id = entity.Id;
                viewModel.Name = entity.FirstName + " " + entity.LastName;
                viewModel.Description = entity.Description;
                viewModel.Email = entity.Email;
                viewModel.Phone = entity.Phone;
                viewModel.Skype = entity.Skype;
            }

            return viewModel;
        }

        public static Candidate ToCandidateEntity(this CandidateViewModel viewModel)
        {
            var entity = new Candidate();

            if (viewModel != null)
            {
                entity.Id = viewModel.Id;
                entity.FirstName = viewModel.Name;
                entity.Description = viewModel.Description;
                entity.Email = viewModel.Email;
                entity.Phone = viewModel.Phone;
                entity.Skype = viewModel.Skype;
            }

            return entity;
        }
    }
}
