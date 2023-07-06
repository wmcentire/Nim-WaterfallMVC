using Microsoft.AspNetCore.Mvc;
using Nim_WaterfallMVC.Models;
using System.Diagnostics;

namespace Nim_WaterfallMVC.Controllers
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

        public IActionResult PVPInput()
        {
            return View();
        }

        public IActionResult PVCInput()
        {
            return View();
        }

        public IActionResult Rule()
        {
            return View();
        }

        public IActionResult Game(string P1Name, string P2Name)
        {
            if (P2Name == null)
            {
                P2Name = "Computer";
            }

            ViewBag.P1Name = P1Name;
            ViewBag.P2Name = P2Name;

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