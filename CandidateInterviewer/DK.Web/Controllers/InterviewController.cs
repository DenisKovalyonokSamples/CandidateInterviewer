using System;
using System.Collections.Generic;
using System.Linq;
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

            int examId = 0; //FIX: create real exam

            return RedirectToAction(nameof(Exam), new { id = examId });
        }

        [HttpGet]
        public async Task<IActionResult> Exam(int id)
        {

            return View();
        }
    }
}