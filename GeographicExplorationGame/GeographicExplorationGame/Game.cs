using System.Numerics;

namespace GameMapExploration
{
    public class Game
    {
        private Player Player;
        private Map Map;
        private Random random = new Random();

        public Game(string name)
        {
            Player = new Player(name);
            int mapSize = random.Next(6, 9);
            Map = new Map(mapSize);

        }

        public void Start()
        {
            while (true)
            {
                Map.ShowMap(Player.X, Player.Y);
                Console.WriteLine();
                Console.WriteLine($"You are at ( {Player.X} , {Player.Y} )");

                string feature = Convert.ToString(Map.MapArray[Player.X, Player.Y].Feature);
                Console.WriteLine($"{feature}:");

                string description = Map.MapArray[Player.X, Player.Y].Description;
                Console.WriteLine(description);
                Console.WriteLine("\nWhere do you want to move?");
                Console.WriteLine("type w, d, s, a or EXIT to exit");
                string input = Console.ReadLine();
                if (input == "EXIT")
                {
                    break;
                }

                MovePlayer(input);
            }
        }
        public void MovePlayer(string direction)
        {
            string uppercase = direction.ToUpper();
            switch (uppercase)
            {
                case "W":
                    if (Player.X > 0)
                    {
                        Player.Move(-1, 0);
                    }

                    break;
                case "S":
                    if (Player.X < Map.Rows - 1)
                    {
                        Player.Move(1, 0);
                    }

                    break;
                case "D":
                    if (Player.Y < Map.Columns - 1)
                    {
                        Player.Move(0, 1);
                    }
                    break;
                case "A":
                    if (Player.Y > 0)
                    {
                        Player.Move(0, -1);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid move. Please enter N, S, E, W, or 'exit'.");
                    break;
            }
        }

    }
}
