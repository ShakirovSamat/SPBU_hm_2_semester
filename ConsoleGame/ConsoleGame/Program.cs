namespace ConsoleGame
{
    class Program
    {
        public delegate void ArrowHandler();
        public static void Main()
        {
            Console.WriteLine("        *****Adventure*****");
            Console.Write("Enter absolute path to the map file: ");
            string? absolutePath;
            while (true)
            {
                Console.Write("Enter absolute path to the map file: ");
                absolutePath = Console.ReadLine();
                if (File.Exists(absolutePath))
                {
                    break;
                }
                Console.WriteLine("File dosn't exist");
            }


            string gameField = File.ReadAllText(absolutePath);
            Game game = new Game(gameField);
            game.Run();
        }
    }
}