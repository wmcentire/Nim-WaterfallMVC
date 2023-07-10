namespace Nim_WaterfallMVC.Models
{
    public class Board
    {
        int turn = 0;
        Player[] players = new Player[2];
        int dif;

        int chosenRow = 0;

        bool playerHasWon = false;
        Player winner;

        public Board(string pl1Name, string pl2Name, int difficulty)
        {
            Player pl1 = new Player(pl1Name);
            Player pl2 = new Player(pl2Name);

            dif = difficulty;
        }

        public string StartGame()
        {



            return winner.Name;
        }
    }
}
