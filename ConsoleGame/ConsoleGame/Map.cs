using System.Security.Cryptography.X509Certificates;

namespace ConsoleGame
{
    public class Map
    {
        public enum MapCell
        {
            Empty = ' ',
            Character = '@'
        }

        string[] mapMatrix;

       
        public Map(string map)
        {
            mapMatrix = map.Split('\n');
        }

        public bool IsLeftEmpty(Character character)
        {
            return character.XPosition - 1 >= 0 && mapMatrix[character.YPosition][character.XPosition - 1] == (char)MapCell.Empty;
        }

        public bool IsRightEmpty(Character character)
        {
            return mapMatrix[character.YPosition][character.XPosition + 1] == (char)MapCell.Empty;
        }

        public bool IsDownEmpty(Character character)
        {
            return mapMatrix[character.YPosition + 1][character.XPosition] == (char)MapCell.Empty;
        }

        public bool IsUpEmpty(Character character)
        {
            return character.YPosition - 1 >= 0 && mapMatrix[character.YPosition - 1][character.XPosition] == (char)MapCell.Empty;
        }

    }
}
