namespace ConsoleGame
{
    public class Map
    {
        string[] map;
        public Map(string map)
        {
            map = "\n \n" + map;
            this.map = map.Split('\n');
        }

        public bool IsLeftEmpty(Character character)
        {
            return  character.XPosition - 1 >= 0 && map[character.YPosition][character.XPosition - 1] == ' ';           
        }

        public bool IsRightEmpty(Character character)
        {
            return map[character.YPosition][character.XPosition + 1] == ' ';
        }

        public bool IsDownEmpty(Character character)
        {
            return map[character.YPosition + 1][character.XPosition] == ' ';
        }

        public bool IsUpEmpty(Character character)
        {
            return character.YPosition - 1 >= 2 && map[character.YPosition - 1][character.XPosition] == ' ';
        }

    }
}
