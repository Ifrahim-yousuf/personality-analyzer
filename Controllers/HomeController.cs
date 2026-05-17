using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PersonalityAnalyzer.Models;

namespace PersonalityAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
        public IActionResult Result(string type)
        {
            if (type == "lion")
            {
                ViewBag.Message = "You are brave and confident.";
            }
            else if (type == "ocean")
            {
                ViewBag.Message = "You are calm and thoughtful.";
            }
            else
            {
                ViewBag.Message = "Personality not found.";
            }

            return View();
        }
    }
}
