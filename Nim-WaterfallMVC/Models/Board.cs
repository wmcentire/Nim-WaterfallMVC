namespace Nim_WaterfallMVC.Models
{
    public class Board
    {
        int turn = 0;
        Player[] players = new Player[2];
        int dif;

        int chosenRow = -1;

        Rows[] rows;

        bool playerHasWon = false;
        Player currentPlayer;

        public Board(string pl1Name, string pl2Name, int difficulty)
        {
            Player pl1 = new Player(pl1Name);
            Player pl2 = new Player(pl2Name);

            dif = difficulty;
        }

        public void StartGame()
        {
            rows = new Rows[dif];
            foreach(Rows row in rows)
            {
                for(int i = 0; i < row.len; i++)
                {
                    row.matches[i] = true;
                }
            }
            currentPlayer = players[turn];
        }

        public void PassTurn()
        {
            turn++;
        }


    }
}
