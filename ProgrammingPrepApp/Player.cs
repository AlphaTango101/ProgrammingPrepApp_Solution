namespace ProgrammingPrepApp
{
    public class Player
    {

        public string Name { get; set; }
        public int Health { get; set; }
        public int Strength { get; set; }
        public int Luck { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }

        public void IncreaseHealth(int extraHealth)
        {
            this.Strength += extraHealth;
        }

    }
}