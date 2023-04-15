using System.ComponentModel.DataAnnotations;

namespace ConsoleGame
{
    public delegate void ArrowHandler();
    public class Game
    {
        Map map;
        Character character;
        ArrowHandler left, right, up, down;

        public Game(string gameField)
        {
            try
            {
                character = new Character(gameField);
            }
            catch (WrongMapException e)
            {
                Console.WriteLine(e.Message);
            }

            gameField = gameField.Replace('@', ' ');
            map = new Map(gameField);


            Drawer.DrawMap(gameField);
            Console.SetCursorPosition(character.XPosition, character.YPosition);
            Drawer.DrawCharacter(character.XPosition, character.YPosition);

            left = () =>
            {
                if (map.IsLeftEmpty(character))
                {
                    character.LeftStep();
                    Drawer.DrawCharacter(character.XPosition, character.YPosition);
                }
            };

            right = () =>
            {
                if (map.IsRightEmpty(character))
                {
                    character.RightStep();
                    Drawer.DrawCharacter(character.XPosition, character.YPosition);
                }
            };


            down = () =>
            {
                if (map.IsDownEmpty(character))
                {
                    character.DownStep();
                    Drawer.DrawCharacter(character.XPosition, character.YPosition);
                }
            };

            up = () =>
            {
                if (map.IsUpEmpty(character))
                {
                    character.UpStep();
                    Drawer.DrawCharacter(character.XPosition, character.YPosition);
                }
            };

        }

            public void Run()
            {
                while (true)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            left();
                            break;

                        case ConsoleKey.RightArrow:
                            right();
                            break;

                        case ConsoleKey.DownArrow:
                            down();
                            break;

                        case ConsoleKey.UpArrow:
                            up();
                            break;
                    }
                }
            }
        }
    }