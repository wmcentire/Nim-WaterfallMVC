using Microsoft.AspNetCore.Mvc;
using Nim_WaterfallMVC.Models;
using System.Diagnostics;

namespace Nim_WaterfallMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // Logger instance for logging
        private Board board; // Instance of the game board

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger; // Initialize the logger
        }

        // Action method for the home page
        public IActionResult Index()
        {
            return View();
        }

        // Action method for player vs. player input page
        public IActionResult PVPInput()
        {
            return View();
        }

        /*
        // Action method for player vs. computer input page
        public IActionResult PVCInput()
        {
            return View();
        }
        */

        // Action method for displaying the game rules
        public IActionResult Rule()
        {
            return View();
        }

        // Action method for displaying the credits
        public IActionResult Credit()
        {
            return View();
        }

        // Action method for starting the game
        public IActionResult Game(string P1Name, string P2Name, int difficulty)
        {
            board = new Board(P1Name, P2Name, difficulty); // Create a new game board
            ViewBag.Game = board; // Pass the board to the view

            if (P1Name == null)
            {
                ViewBag.P1Name = "Player 1";
            }

            if (P2Name == null)
            {
                ViewBag.P2Name = "Player 2";
            }

            return View();
        }

        // Action method for privacy policy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Action method for handling errors
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // Create an ErrorViewModel and pass the request ID for error tracking
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
