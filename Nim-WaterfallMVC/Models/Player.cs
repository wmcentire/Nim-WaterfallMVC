namespace Nim_WaterfallMVC.Models
{
    public class Player
    {
        bool won;
        string name;

        public string Name { get { return name; } set { name = value; } }
        public bool Won { get {  return won; } set {  won = value; } }

        public Player() { }

        public Player(bool won, string name)
        {
            Won = won;
            Name = name;

        }
    }
}
