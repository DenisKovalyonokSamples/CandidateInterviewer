using DK.Core;
using DK.DataAccess.Entities;
using DK.DataAccess.Enums;
using DK.Web.ViewModels;
using System;
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

        public static ExamViewModel GetExamViewModel(Interview interview, Exam exam, Candidate candidate, List<Question> questions, List<Answer> answers)
        {
            var viewModel = new ExamViewModel();

            viewModel.Id = exam.Id;
            viewModel.CategoryId = exam.CategoryId;
            viewModel.CandidateId = candidate.Id;
            viewModel.InterviewId = interview.Id;
            viewModel.CandidateFullName = candidate.FirstName + " " + candidate.LastName;
            viewModel.CandidateDescription = candidate.Description;
            viewModel.CandidateEmail = candidate.Email;
            viewModel.CandidatePhone = candidate.Phone;
            viewModel.Type = exam.Type;
            viewModel.Logo = exam.Logo;
            viewModel.Name = exam.Name;
            viewModel.Description = exam.Description;
            viewModel.TypeLogo = MediaManager.GetIconForExamType(exam.Type);
            viewModel.Questions = GetQuestionsForExamViewModel(questions, answers);

            return viewModel;
        }

        public static List<Response> GetExamResponses(ExamViewModel model)
        {
            var entities = new List<Response>();

            if (model.Questions?.Any() == true)
            {
                foreach (var question in model.Questions)
                {
                    var response = new Response();
                    response.InterviewId = model.InterviewId;
                    response.QuestionId = question.Id;

                    if (question.Type == AnswerType.Text)
                    {
                        response.IsApproved = false;
                        response.ApprovalType = ApprovalType.Manual;
                        response.Value = question.CandidateAnswer;
                    }

                    if (question.Type == AnswerType.Single)
                    {
                        var selectedAnswer = question.Answers?.FirstOrDefault(e => e.Value == question.CandidateAnswer);
                        if (selectedAnswer != null)
                        {
                            response.IsApproved = true;
                            response.ApprovalType = ApprovalType.Automatical;
                            response.Value = question.CandidateAnswer;
                        }
                    }

                    if (question.Type == AnswerType.Multiple)
                    {
                        var candidateAnswers = question.Answers?.Where(e => e.CandidateAnswer)?.ToList() ?? new List<AnswerViewModel>();
                        foreach (var answer in candidateAnswers)
                        {
                            response.Value += answer.Value + Constants.ANSWER_SEPARATOR;
                        }

                        response.IsApproved = true;
                        response.ApprovalType = ApprovalType.Automatical;
                    }

                    if (!string.IsNullOrEmpty(response.Value))
                    {
                        entities.Add(response);
                    }
                }
            }

            return entities;
        }

        public static List<ResponseViewModel> GetResponseViewModels(List<Response> responses)
        {
            var viewModel = new List<ResponseViewModel>();

            if (responses?.Any() == true)
            {
                viewModel = responses.Select(o => new ResponseViewModel()
                {
                    Id = o.Id,
                    InterviewId = o.InterviewId,
                    QuestionId = o.QuestionId,
                    Type = o.ApprovalType,
                    IsApproved = o.IsApproved,
                    Value = o.Value
                })?.ToList() ?? new List<ResponseViewModel>();
            }

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

        public static CompleteViewModel GetCompleteViewModel(Interview interview, Exam exam, Candidate candidate)
        {
            var viewModel = new CompleteViewModel();

            viewModel.InterviewId = interview.Id;
            viewModel.Score = interview.Score;
            viewModel.CandidateName = candidate.FirstName + " " + candidate.LastName;
            viewModel.CandidateDescription = candidate.Description;
            viewModel.ExamLogo = exam.Logo;
            viewModel.ExamTypeLogo = MediaManager.GetIconForExamType(exam.Type);
            viewModel.Type = exam.Type;

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

        public static ResultViewModel GetResultViewModels(Interview interview, Candidate candidate, Exam exam)
        {
            var viewModel = new ResultViewModel();

            viewModel.InterviewId = interview.Id;
            viewModel.Score = Convert.ToInt32(interview.Score);
            viewModel.CandidateFullName = candidate.FirstName + " " + candidate.LastName;
            viewModel.CandidateDescription = candidate.Description;
            viewModel.ExamLogo = exam.Logo;
            viewModel.ExamTypeLogo = MediaManager.GetIconForExamType(exam.Type);
            viewModel.Type = exam.Type;
            viewModel.Date = interview.Date;
            viewModel.ExamName = exam.Name;
            viewModel.Email = candidate.Email;

            return viewModel;
        }
    }
}
