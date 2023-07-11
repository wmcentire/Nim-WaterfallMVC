namespace Nim_WaterfallMVC.Models
{
    public class Rows
    {
        public int len; // Represents the length of the row
        
        public bool[] matches; // An array representing the presence or absence of matches in each position of the row

        public Rows(int len)
        {
            matches = new bool[len]; // Initializes the matches array with the specified length
        }

        public bool getEmpty()
        {
            for(int i = 0; i < len; i++)
            {
                if (matches[i]) // Checks if there is a match present at the current position
                {
                    return true; // Returns true if there is at least one match present
                }
            }
            return false; // Returns false if there are no matches present in any position
        }

        public int matchCount()
        {
            int lit = 0; // Counter variable to keep track of the number of matches

            for(int i = 0; i < len; i++)
            {
                if (matches[i]) lit++; // Increments the counter if a match is present at the current position
            }

            return lit; // Returns the total number of matches present in the row
        }
    }
}
