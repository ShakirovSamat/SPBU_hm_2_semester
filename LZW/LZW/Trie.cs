using System.Diagnostics.Contracts;

namespace LZW
{
    public class Trie
    {
        Node head = new Node(' ');
        int amountOfWords;
        Dictionary<int ,string> words = new();
        private class Node
        {
            public char value;
            public int number;
            public Dictionary<char, Node> children = new Dictionary<char, Node>();

            public Node(char value)
            {
                this.value = value;
            }
        }


        public void Add(string word)
        {
            if (Contains(word))
            {
                return;
            }
            words.Add(amountOfWords, word);
            Node currentNode = head;

            foreach (char sign in word)
            {
                if (!currentNode.children.ContainsKey(sign))
                {
                    Node newNode = new Node(sign);
                    currentNode.children[sign] = (newNode);
                }

                currentNode = currentNode.children[sign];
            }
            currentNode.number = amountOfWords;
            ++amountOfWords;
        }

        public bool Contains(string word)
        {
            Node currentNode = head;
            foreach (char sign in word)
            {
                if (!currentNode.children.ContainsKey(sign))
                {
                    return false;
                }
                currentNode = currentNode.children[sign];
            }
            return true;
        }

        public int GetNumberByWord(string word)
        {
            if (!Contains(word))
            {
                return -1;
            }

            Node currentNode = head;
            foreach (char sign in word)
            {
                currentNode = currentNode.children[sign];
            }
            return currentNode.number;
        }

        public string GetWordByNumber(int number)
        {
            return words[number];
        }

        public int GetAmountOfWords()
        {
            return amountOfWords;
        }


    }
}
