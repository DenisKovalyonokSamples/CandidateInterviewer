using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DK.Web.Models;
using DK.DataAccess.Interfaces;
using System.Linq;
using DK.Web.ViewModels;
using System.Collections.Generic;

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

            var viewModel = new HomeViewModel();
            viewModel.Catgories = categories?
              .Select(o => new CategoryViewModel()
              {
                  Id = o.Id,
                  Name = o.Name,
                  Description = o.Description,
                  Logo = o.Logo
              })?.ToList() ?? new List<CategoryViewModel>();

            return View(viewModel);
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
