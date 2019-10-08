using System.Threading.Tasks;
using DK.DataAccess.Interfaces;
using DK.Web.Managers;
using DK.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
            var exam = await _interviewService.GeExamAsync(interview.ExamId);

            return View();
        }
    }
}