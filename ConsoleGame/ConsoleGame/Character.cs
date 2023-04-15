namespace ConsoleGame
{
    public class Character
    {
        public int XPosition { get; private set; }
        public int YPosition { get; private set; }

        public Character(string gameField)
        {
            var currentCharactertPosition = GetStartCharacterPosition(gameField);
            if (currentCharactertPosition == null)
            {
                throw new WrongMapException("There is no character on the map");
            }

            XPosition = currentCharactertPosition.Value.Item1;
            YPosition = currentCharactertPosition.Value.Item2 + 2;
        }
        public (int, int)? GetStartCharacterPosition(string map)
        {
            int left = 0;
            int top = 0;
            for (int i = 0; i < map.Length; ++i)
            {
                if (map[i] == '@')
                {
                    return (left, top);
                }

                left++;
                if (map[i] == '\n')
                {
                    left = 0;
                    top++;
                }
            }
            return null;
        }

        public void LeftStep()
        {
            --XPosition;
        }
        public void RightStep()
        {
            ++XPosition;
        }
        public void UpStep()
        {
            --YPosition;
        }
        public void DownStep()
        {
            ++YPosition;
        }
    }
}
