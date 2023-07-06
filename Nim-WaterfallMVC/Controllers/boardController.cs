using Microsoft.AspNetCore.Mvc;
using Nim_WaterfallMVC.Models;

namespace Nim_WaterfallMVC.Controllers
{
    public class boardController : Controller
    {
        bool turn;
        Player player = null;
        Player player2 = null;
        int dif;

        public IActionResult Index()
        {

            dif=ViewBag.dif;
            Row[] rows = new Row[5+dif];

            return View();
        }
        public void onNextPress(int row)
        {
            

        }
    }
}
