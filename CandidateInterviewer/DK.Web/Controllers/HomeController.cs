using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DK.DataAccess.Interfaces;
using System.Linq;
using DK.Web.ViewModels;
using System.Collections.Generic;
using DK.Web.Managers;

namespace DK.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInterviewService _interviewService;
        private readonly IUserService _userService;

        public HomeController(IInterviewService interviewService, IUserService userService)
        {
            _interviewService = interviewService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = await _interviewService.GetCategoriesAsync();
            var viewModel = ViewModelBuilder.GetHomeViewModel(categories);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Interviews()
        {
            var categories = await _interviewService.GetCategoriesAsync();
            var viewModel = ViewModelBuilder.GetInterviewsViewModel(categories);

            return View(viewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Results()
        {
            var interviews = await _interviewService.GetPassedInterviewsAsync();
            var candidates = await _userService.GetCandidatesAsync();

            if (interviews?.Any() != true || candidates?.Any() != true)
            {
                return RedirectToAction(nameof(HomeController.Error));
            }

            var viewModels = new List<ResultViewModel>();

            foreach (var interview in interviews)
            {
                var candidate = candidates.FirstOrDefault(e => e.Id == interview.CandidateId);

                if (candidate != null)
                {
                    var exam = await _interviewService.GetExamAsync(interview.ExamId);
                    viewModels.Add(ViewModelBuilder.GetResultViewModels(interview, candidate, exam));
                }
            }

            return View(viewModels.OrderByDescending(e => e.Score).ToList());
        }

        [HttpGet]
        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
