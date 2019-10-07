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

        public HomeController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
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
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Contacts()
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
