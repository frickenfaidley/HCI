using Last_Hope_Dating.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Last_Hope_Dating.Controllers
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

        public IActionResult Matched()
        {
            return View();
        }

        public IActionResult AddPfP()
        {
            return View();
        }

        public IActionResult FindMatches()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AccountCreate()
        {
            return View();
        }

        public IActionResult CreateConfirm()
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