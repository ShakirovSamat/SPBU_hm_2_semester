namespace tic_tac_toe
{
    public class Game
    {
        private class Node
        {
            public char? value;
        }

        private Node[,] nodes = new Node[3, 3];
        private byte amountOfClearNodes = 9;
        public char currentChar = 'X';
        public Game()
        {
            for (int i = 0; i < 3; ++i)
            {
                for (int j = 0; j < 3; ++j)
                {
                    nodes[i, j] = new Node();
                }
            }
        }

        public char? AddValueToNode(int nodePosition)
        {
            nodes[nodePosition / 3, nodePosition % 3].value = currentChar;
            if (currentChar == 'X')
            {
                currentChar = 'O';
            }
            else
            {
                currentChar = 'X';
            }
            amountOfClearNodes--;
            return IsGameOver();

        }

        public char? IsGameOver()
        {
            for (int i = 0; i < 3; ++i)
            {
                if (nodes[i, 0].value == nodes[i, 1].value && nodes[i, 1].value == nodes[i, 2].value)
                {
                    return nodes[i, 0].value;
                }

                if (nodes[0, i].value == nodes[1, i].value && nodes[1, i].value == nodes[2, i].value)
                {
                    return nodes[0, i].value;
                }
            }

            if (nodes[0, 0].value == nodes[1, 1].value && nodes[1, 1].value == nodes[2, 2].value)
            {
                return nodes[0, 0].value;
            }

            if (nodes[0, 2].value == nodes[1, 1].value && nodes[1, 1].value == nodes[2, 0].value)
            {
                return nodes[0, 2].value;
            }

            if (amountOfClearNodes == 0)
            {
                return '=';
            }

            return null;
        }

        public bool isSettled(int position)
        {
            return nodes[position / 3, position % 3].value != null;
        }
    }
}
