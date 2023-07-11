namespace Nim_WaterfallMVC.Models
{
    public class Player
    {
        // Private field to store the player's name
        string name;


        // Public property to get and set the player's name
        // The Player class represents a player in the game. It contains the following:

        public string Name { get { return name; } set { name = value; } }

        public Player() { }

        public Player(string name)
        {
            Name = name;

        }
    }
}
