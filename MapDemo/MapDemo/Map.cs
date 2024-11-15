namespace GameMapExploration
{
    public class Map
    {
        public int Rows {  get; }
        public int Columns { get; }
        public Location[,] MapArray;

        public Map(int mapSize)
        {
            Rows = mapSize;
            Columns = mapSize;
            CreateMap();
        }
        private void CreateMap()
        {
            MapArray = new Location[Rows, Columns];

            for (int i = 0;  i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MapArray[i, j] = new Location() { Name = "o" };
                }
            }
        }
        public void ShowMap(int x, int y)
        {
            Console.Clear();
            for (int row = 0; row < Rows; row++)
            {
                for (int column = 0; column < Columns; column++)
                {
                    //convert fron string to console color
                    ConsoleColor colors = MapArray[row, column].ConsoleColors;
                    Console.BackgroundColor = colors;
                    if (x == row && y == column)
                    {
                        Console.Write(" X ");
                        //Console.ResetColor();  
                    }
                    else
                    {
                        Console.Write(" " + MapArray[row, column].Name + " ");
                        //Console.ResetColor();
                    }
                }
                Console.BackgroundColor = ConsoleColor.White;
                Console.Write("\n"); 
            }
        }
    }
}
