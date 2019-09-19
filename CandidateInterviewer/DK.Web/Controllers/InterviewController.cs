using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DK.Web.Controllers
{
    public class InterviewController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}