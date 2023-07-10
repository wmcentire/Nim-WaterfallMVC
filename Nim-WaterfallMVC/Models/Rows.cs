namespace Nim_WaterfallMVC.Models
{
    public class Rows
    {
        public int len;

        public bool[] matches;

        public Rows(int len)
        {
            matches = new bool[len];
        }

        public bool getEmpty()
        {
            for(int i = 0; i < len; i++)
            {
                if (matches[i])
                {
                    return true;
                }
            }
            return false;
        }

        public int matchCount()
        {
            int lit = 0;
            for(int i = 0; i < len; i++)
            {
                if (matches[i]) lit++;
            }
            return lit;
        }
    }
}
