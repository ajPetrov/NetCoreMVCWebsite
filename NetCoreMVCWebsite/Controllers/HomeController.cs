using Microsoft.AspNetCore.Mvc;
using NetCoreMVCWebsite.Models;
using System.Diagnostics;

namespace NetCoreMVCWebsite.Controllers
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

        public IActionResult ForUs()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult Newspaper()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult Admissions()
        {
            return View();
        }

        public IActionResult ForYou()
        {
            return View();
        }

        public IActionResult Projects()
        {
            return View();
        }

        public IActionResult Materials()
        {
            return View();
        }

        public IActionResult Gallery()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult SchoolHistory()
        {
            return View();
        }

        public IActionResult WhoIsBogorov()
        {
            return View();
        }

        public IActionResult SchoolCouncel()
        {
            return View();
        }

        public IActionResult Anthem()
        {
            return View();
        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Links()
        {
            return View();
        }

        public IActionResult HotLinks()
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