using Microsoft.AspNetCore.Mvc;
using Nim_WaterfallMVC.Models;
using System.Diagnostics;

namespace Nim_WaterfallMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private Board board;
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

        public IActionResult Game(string P1Name, string P2Name, int difficulty)
        {
            if (P2Name == null)
            {
                P2Name = "Computer";
            }
            board = new Board(P1Name,P2Name,difficulty);
            ViewBag.Game = board;

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