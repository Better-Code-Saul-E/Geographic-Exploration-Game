/* 
 * Game Map Exploration
 * Saul Enriqez
 * 10/16/2024
*/
namespace GameMapExploration
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("What is your name fellow Adventurer?");
            string name = Console.ReadLine();
            Game Game = new Game(name);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Game.Start();
        }
    }
}