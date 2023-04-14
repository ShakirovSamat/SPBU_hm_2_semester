namespace tic_tac_toe
{
    public class Game
    {

        private class Node
        {
            public char? value;
        }

        Node[,] gameTable = new Node[3, 3];
        int amountOfClearNode = 9;
        char currentGameChar ='X';

        public Game()
        {
            for (int i= 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    gameTable[i, j] = new Node();
                }
            }
        }

        public char? AddValueToNode(int position)
        {
            gameTable[position / 3, position % 3].value = currentGameChar;
            if (currentGameChar == 'X')
            {
                currentGameChar = 'O';
            }
            else
            {
                currentGameChar = 'X';
            }

            amountOfClearNode--;
            return IsGameOver();
        }

        public char? IsGameOver()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (gameTable[i, 0].value == gameTable[i, 1].value && gameTable[i, 1].value == gameTable[i, 2].value)
                {
                    return gameTable[i, 0].value;
                }

                if (gameTable[0, i].value == gameTable[1, i].value && gameTable[1, i].value == gameTable[2, i].value)
                {
                    return gameTable[0, i].value;
                }
            }

            if (gameTable[0, 0].value == gameTable[1, 1].value && gameTable[1, 1].value == gameTable[2, 2].value)
            {
                return gameTable[0, 0].value;
            }

            if (gameTable[0, 2].value == gameTable[1, 1].value && gameTable[1, 1].value == gameTable[0, 2].value)
            {
                return gameTable[0, 2].value;
            }

            if (amountOfClearNode == 0)
            {
                return '=';
            }
            
            return null;
        }

        public bool isSettled(int position)
        {
            return gameTable[position / 3, position % 3].value != null;
        }

        public char GetCurrentGameChar()
        {
            return currentGameChar;
        }
    }
}
