namespace GameMapExploration
{
    public class Location
    {
        public enum GeologicalFeature
        {
            IceBerg,
            Volcano,
            Moutain,
            WaterFall,
            Forest,
            Plain,
            Beach,
            Desert,
            Mesa,
            Lake,
            Ocean,
            Bay,
            Tundra
        }
        private enum Colors
        {
            White,
            DarkRed,
            DarkGray,
            Gray,
            DarkGreen,
            Green,
            Yellow,
            DarkYellow,
            Red,
            DarkCyan,
            DarkBlue,
            Cyan,
            DarkMagenta
        }
        public string Name;
        public ConsoleColor ConsoleColors { get; set; }
        public GeologicalFeature Feature;
        public string Description;
        Random random = new Random();

        public Location()
        {
            int randomNumber = random.Next(10);
            string randomLocation = Convert.ToString((Colors)randomNumber);
            ConsoleColors = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), randomLocation, true);
            Feature = (GeologicalFeature)randomNumber;
            GetDescription();
        }

        private void GetDescription()
        {
            string feature = Convert.ToString(Feature);
            switch (feature)
            {
                case "IceBerg":
                    Description = "a large floating mass of ice";
                    break;

                case "Volcano":
                    Description = "A towering mountain with the potential for explosive eruptions.";
                    break;
                case "Moutain":
                    Description = "A towering, rugged landform with steep slopes and breathtaking views";
                    break;
                case "WaterFall":
                    Description = "A stunning cascade of water crashing down into a serene pool below.";
                    break;
                case "Forest":
                    Description = "A dense area filled with trees, wildlife, and hidden paths.";
                    break;
                case "Plain":
                    Description = "An expansive, flat landscape covered in grasses and wildflowers.";
                    break;
                case "Beach":
                    Description = "A vivid shoreline with soft sand and gentle waves.";
                    break;
                case "Desert":
                    Description = "A vast, arid landscape of shifting sands and sparse vegetation.";
                    break;
                case "Mesa":
                    Description = "A flat topped hill rising dramatically above the surrounding land.";
                    break;
                case "Lake":
                    Description = "A calm body of water surrounded by lush greenery.";
                    break;
                case "Ocean":
                    Description = "A vast expanse of saltwater teeming with marine life.";
                    break;
                case "Bay":
                    Description = "A sheltered body of water offering a calm harbor.";
                    break;
                case "Tundra":
                    Description = "A cold treeless biome characterized by permafrost, low vegetation, and short growing seasons.";
                    break;
            }
        }
    }
}
