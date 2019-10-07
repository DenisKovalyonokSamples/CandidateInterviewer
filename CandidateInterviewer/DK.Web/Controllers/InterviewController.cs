using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DK.DataAccess.Interfaces;
using DK.Web.Managers;
using Microsoft.AspNetCore.Mvc;

namespace DK.Web.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;

        public InterviewController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var category = await _interviewService.GetCategoryAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            var viewModel = ViewModelBuilder.GetCategoryViewModel(category);

            return View(viewModel);
        }
    }
}