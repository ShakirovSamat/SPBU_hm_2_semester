namespace ConsoleGame
{
    public static class Drawer
    {
        public static void DrawCharacter(int x, int y)
        {
            Console.Write("\b \b");
            Console.SetCursorPosition(x, y);
            Console.Write((char)Map.MapCell.Character);
        }

        public static void DrawMap(string map)
        {
            Console.Clear();
            Console.Write(map);
        }
    }
}
