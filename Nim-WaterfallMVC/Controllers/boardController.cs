using Microsoft.AspNetCore.Mvc;
using Nim_WaterfallMVC.Models;

namespace Nim_WaterfallMVC.Controllers
{
    public class boardController : Controller
    {
        bool p1turn;
        Player[] players = new Player[2];//using a list of players for easiear tracking
        int dif;

        int[] rowSizes;
        bool wasPressed = false;


        bool playerHasWon = false;

        public IActionResult Index()
        {
            players = new Player[players.Length];

            dif = ViewBag.dif;//reads the input for the dif from the view and uses that to set the number of rows 
            switch (dif)
            {
                case 1:
                    rowSizes = new int[] { 1, 3, 5, 7 };
                    break;
                case 2:
                    rowSizes = new int[] { 1, 3, 5, 7, 9 };
                    break;
                case 3:
                    rowSizes = new int[] { 1, 3, 5, 7, 9, 11 };
                    break;


            }


            return View();
        }

        public void nameSubmit()
        {
            //takes in the names of the players from the input
            Player player1 = new Player(false, ViewBag.player1name);
            Player player2 = new Player(false, ViewBag.player2name);
            players[0] = player1;
            players[1] = player2;

            //go to next page
        }

        public void rowPress(int row)
        {
            int i = 0;

            if (rowSizes[row] < dif)
            {
                if (rowSizes[row] > 0)
                {
                    rowSizes[row]--;
                }
            }

        }

        public void onNextPress(int row)
        {
            bool matchWasFound = false;
            if (wasPressed)//checks to see if they have removed matche from a row
            {
                for (int i = 0; i < rowSizes.Length; i++)//check to see if there is a match any spot in the list
                {
                    if (rowSizes[i] > 0)
                    {
                        matchWasFound = true;
                        break;
                    }

                }


                if (matchWasFound)//if there was a true match then it lets the game continue
                {
                    matchWasFound = false;
                    if (p1turn)
                    {
                        p1turn = false;
                    }
                    else
                    {
                        p1turn = true;
                    }

                }
                else//if there wasn't a true match left then it ends the game and choose the winner as the oppsite of the turn order
                {
                    if (p1turn)
                    {
                        p1turn = false;
                        playerHasWon = true;
                        players[2].Won = true;
                    }
                    else
                    {
                        p1turn = true;
                        playerHasWon = true;
                        players[1].Won = true;

                    }
                }
            }
            else// if they didn't remove a match from a row
            {
                //send message back saying that you need to press a button firsts
            }

        }
    }
}
