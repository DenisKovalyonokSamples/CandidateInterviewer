using System.Threading.Tasks;
using DK.DataAccess.Interfaces;
using DK.Web.Managers;
using DK.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Collections.Generic;
using DK.DataAccess.Entities;

namespace DK.Web.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;
        private readonly IUserService _userService;

        public InterviewController(IInterviewService interviewService, IUserService userService)
        {
            _interviewService = interviewService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var category = await _interviewService.GetCategoryAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var viewModel = ViewModelBuilder.GetInterviewViewModel(category);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(InterviewViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var candidate = await _userService.InitCandidateAsync(model.Candidate.ToCandidateEntity());
            var exam = await _interviewService.GetExamByCategoryAsync(model.Category.Id, model.SelectedExamType);

            if (candidate == null || exam == null)
            {
                return RedirectToAction(nameof(HomeController.Error));
            }

            var interview = await _interviewService.InitInterviewAsync(candidate.Id, exam.Id);

            return RedirectToAction(nameof(Exam), new { id = interview.Id });
        }

        [HttpGet]
        public async Task<IActionResult> Exam(int id)
        {
            var interview = await _interviewService.GetInterviewAsync(id);
            var exam = await _interviewService.GetExamAsync(interview.ExamId);
            var candidate = await _userService.GetCandidateAsync(interview.CandidateId);

            if (exam == null || candidate == null)
            {
                return RedirectToAction(nameof(HomeController.Error));
            }

            var answers = new List<Answer>();
            var examQuestions = await _interviewService.GetQuestionsForExamAsync(interview.ExamId);
            if (examQuestions?.Any() == true)
            {
                foreach (var question in examQuestions)
                {
                    var questionAnswers = await _interviewService.GetAnswersForQuestionAsync(question.Id);
                    if (questionAnswers?.Any() == true)
                    {
                        answers.AddRange(questionAnswers);
                    }
                }
            }

            var viewModel = ViewModelBuilder.GetExamViewModel(interview, exam, candidate, examQuestions, answers);

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Exam(ExamViewModel model)
        {
            ModelState.Clear();

            var interview = await _interviewService.GetInterviewAsync(model.InterviewId);
            if (interview != null)
            {
                if(await _interviewService.UpdateInterviewScoreAsync(interview, CalculationManager.CalculateFinalInterviewScore(model.Questions, model.Type)))
                {
                    return RedirectToAction(nameof(Complete), new { id = interview.Id });
                }
            }

            return RedirectToAction(nameof(HomeController.Error));
        }

        [HttpGet]
        public async Task<IActionResult> Complete(int id)
        {
            var interview = await _interviewService.GetInterviewAsync(id);
            var exam = await _interviewService.GetExamAsync(interview.ExamId);
            var candidate = await _userService.GetCandidateAsync(interview.CandidateId);

            if (interview == null || exam == null || candidate == null)
            {
                return RedirectToAction(nameof(HomeController.Error));
            }

            var viewModel = ViewModelBuilder.GetCompleteViewModel(interview, exam, candidate);

            return View(viewModel);
        }
    }
}