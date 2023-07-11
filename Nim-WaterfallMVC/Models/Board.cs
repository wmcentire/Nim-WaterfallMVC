namespace Nim_WaterfallMVC.Models
{
    public class Board
    {
        int turn = 0; // Current turn, initialized to 0
        Player[] players = new Player[2]; // Array to hold two players
        int dif; // Difficulty level

        int chosenRow = -1; // The chosen row (initialized to -1)
        bool hasWinner = false; // Flag to indicate if there is a winner
        Rows[] rows; // Array to hold the rows

        bool playerHasWon = false; // Flag to indicate if the player has won
        Player currentPlayer; // Current player

        public Board(string pl1Name, string pl2Name, int difficulty)
        {
            Player pl1 = new Player(pl1Name); // Create a new Player object for player 1
            Player pl2 = new Player(pl2Name); // Create a new Player object for player 2

            players[0] = pl1; // Assign player 1 to the first index of the players array
            players[1] = pl2; // Assign player 2 to the second index of the players array

            dif = difficulty; // Set the difficulty level
            StartGame(); // Start the game
        }

        /// <summary>
        /// Method to start the game by creating and populating the rows and setting the first player.
        /// </summary>
        public void StartGame()
        {
            rows = new Rows[4 + dif]; // Create an array of rows based on the difficulty level
            for (int j = 0; j < rows.Length; j++) // Iterate over the rows array
            {
                int length = 1 + (2 * j); // Calculate the length of the row
                rows[j] = new Rows(length); // Create a new row object with the calculated length
                for (int i = 0; i < rows[j].len; i++) // Iterate over the matches in the row
                {
                    rows[j].matches[i] = true; // Set each match to be present initially
                }
            }
            currentPlayer = players[turn]; // Set the current player to the first player
        }

        /// <summary>
        /// Method to pass the turn, update the rows, and check if there are any matches left.
        /// Returns true if no matches are left, and false if there are still matches.
        /// </summary>
        /// <param name="rowIdx">The index of the row</param>
        /// <param name="matchesRemoved">The number of matches removed</param>
        /// <returns>True if no matches are left, false otherwise</returns>
        public bool PassTurn(int rowIdx, int matchesRemoved)
        {
            updateRows(rowIdx, matchesRemoved); // Update the rows by removing matches
            turn++;
            turn = turn % 2; // Set the turn to either 0 or 1 (player 1 or player 2)
            currentPlayer = players[turn]; // Update the current player
            bool hasMatches = false; // Variable to track if there are any matches left
            foreach (Rows row in rows) // Iterate over the rows
            {
                if (!hasMatches)
                {
                    hasMatches = row.getEmpty(); // Check if the row has any matches left
                }
                else
                {
                    break; // Exit the loop if matches are found
                }
            }
            if (!hasMatches) // If there are no matches left, return true
            {
                return true;
            }
            return false; // Else, return false
        }

        /// <summary>
        /// Method to update the rows by removing matches from a given row.
        /// </summary>
        /// <param name="rowIdx">The index of the row</param>
        /// <param name="matchesRemoved">The number of matches removed</param>
        public void updateRows(int rowIdx, int matchesRemoved)
        {
            for (int i = rows[rowIdx].len - rows[rowIdx].matchCount(); i < rows[rowIdx].len - rows[rowIdx].matchCount() + matchesRemoved; i++) // Iterate over the matches to be removed
            {
                // ensuring we dont go out of bounds 
                if (i > rows[rowIdx].len) break;
                rows[rowIdx].matches[i] = false; // Remove the matches from the row
            }
        }
    }
}
