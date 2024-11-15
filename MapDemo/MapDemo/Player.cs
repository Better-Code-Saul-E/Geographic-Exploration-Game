namespace GameMapExploration
{
    public class Player
    {
        public int X {  get; set; }
        public int Y { get; set; }
        public string Name { get; set; }

        public Player(string name)
        {
           Name = name;
            X = 0;
            Y = 0;
        }

        public void Move(int x, int y)
        {
            X += x;
            Y += y;
        }
    }
}
