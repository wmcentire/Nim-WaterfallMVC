namespace Nim_WaterfallMVC.Models
{
    public class Board
    {
        int turn = 0;
        Player[] players = new Player[2];
        int dif;

        int chosenRow = -1;
        bool hasWinner = false;
        Rows[] rows;

        bool playerHasWon = false;
        Player currentPlayer;

        public Board(string pl1Name, string pl2Name, int difficulty)
        {
            Player pl1 = new Player(pl1Name);
            Player pl2 = new Player(pl2Name);

            players[0] = pl1;
            players[1] = pl2;

            dif = difficulty;
            StartGame();
        }

        public void StartGame()
        {
            rows = new Rows[4+dif];
            for(int j = 0; j < rows.Length;j++)
            {
                int length = 1 + 2 * j;
                rows[j] = new Rows(length);
                for(int i = 0; i < rows[j].len; i++)
                {
                    rows[j].matches[i] = true;
                }
            }
            currentPlayer = players[turn];
        }

        public bool PassTurn(int rowIdx, int matchesRemoved)
        {
            updateRows(rowIdx, matchesRemoved);
            turn++;
            turn = turn % 2;
            currentPlayer = players[turn];
            bool hasMatches = false;
            foreach(Rows row in rows)
            {
                if (!hasMatches)
                {
                    hasMatches = row.getEmpty();
                }
                else
                {
                    break;
                }
            }
            if (!hasMatches)
            {
                return true;
            }
            return false;
        }

        public void updateRows(int rowIdx, int matchesRemoved)
        {
            for(int i = rows[rowIdx].len - rows[rowIdx].matchCount(); i < rows[rowIdx].len - rows[rowIdx].matchCount() + matchesRemoved; i++) // len - matches lit // 5 - 3 = 2
            {
                rows[rowIdx].matches[i] = false;
            }
        }
    }
}
