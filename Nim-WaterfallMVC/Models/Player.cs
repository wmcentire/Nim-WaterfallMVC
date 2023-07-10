namespace Nim_WaterfallMVC.Models
{
    public class Player
    {
        string name;

        public string Name { get { return name; } set { name = value; } }

        public Player() { }

        public Player(string name)
        {
            Name = name;

        }
    }
}
