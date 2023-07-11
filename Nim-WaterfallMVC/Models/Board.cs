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
        /// <summary>
        /// creates and populates the rows, and sets first player
        /// </summary>
        public void StartGame()
        {
            rows = new Rows[4+dif];
            for(int j = 0; j < rows.Length;j++) // create a populate rows
            {
                int length = 1 + (2 * j);
                rows[j] = new Rows(length); // creates new row with length 2 greater than the last
                for(int i = 0; i < rows[j].len; i++)
                {
                    rows[j].matches[i] = true;
                }
            }
            currentPlayer = players[turn];
        }
        /// <summary>
        /// calls updateRows, then checks to see if there are any matches left. 
        /// Returns true if no matches are left, and false if there are still matches
        /// </summary>
        /// <param name="rowIdx"></param>
        /// <param name="matchesRemoved"></param>
        /// <returns></returns>
        public bool PassTurn(int rowIdx, int matchesRemoved)
        {
            updateRows(rowIdx, matchesRemoved);
            turn++;
            turn = turn % 2; // sets the turn to either 0 or 1
            currentPlayer = players[turn]; // updates current player
            bool hasMatches = false; // the loop below checks to see if there are any matches left
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
            if (!hasMatches) // if there are no matches left, return true
            {
                return true;
            } // else return false
            return false;
        }
        /// <summary>
        /// removes matches from a given row
        /// </summary>
        /// <param name="rowIdx"></param>
        /// <param name="matchesRemoved"></param>
        public void updateRows(int rowIdx, int matchesRemoved)
        {
            for(int i = rows[rowIdx].len - rows[rowIdx].matchCount(); i < rows[rowIdx].len - rows[rowIdx].matchCount() + matchesRemoved; i++) // len - matches lit // 5 - 3 = 2
            {
                if (i > rows[rowIdx].len) break;
                rows[rowIdx].matches[i] = false;
            }
        }
    }
}
