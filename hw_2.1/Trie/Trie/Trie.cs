namespace Trees.Trie
{
    // Trie data structure realization
    public class Trie
    {
        private TrieNode head;
        public int Size { get; set; }

        private class TrieNode
        {
            public char Value { get; set; }
            public int WordsWithSuchPrefix { get; set; }
            public bool IsTerminated { get; set; }
            public Dictionary<char, TrieNode> Children { get; set; }

            public TrieNode(char value)
            {
                this.Value = value;
                Children = new Dictionary<char, TrieNode>();
                WordsWithSuchPrefix = 1;
            }
            public TrieNode()
            {
                Children = new Dictionary<char, TrieNode>();
                WordsWithSuchPrefix = 1;
            }
        }
        public Trie()
        {
            head = new TrieNode();
        }

        //Adds new word to the trie
        public bool Add(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                throw new WrongInputException("Wrong input");
            }

            if (Contains(word))
            {
                return false;
            }

            TrieNode currentTrieNode = head;
            foreach (char sign in word)
            {
                if (currentTrieNode.Children.ContainsKey(sign))
                {
                    currentTrieNode = currentTrieNode.Children[sign];
                    currentTrieNode.WordsWithSuchPrefix++;
                }
                else
                {
                    currentTrieNode.Children.Add(sign, new TrieNode(sign));
                    currentTrieNode = currentTrieNode.Children[sign];
                }
            }

            currentTrieNode.IsTerminated = true;
            ++Size;
            return true;
        }

        //Searchs the word in the trie
        public bool Contains(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                throw new WrongInputException("Wrong input");
            }

            TrieNode currentTieNode = head;
            foreach (char sign in word)
            {
                if (!currentTieNode.Children.ContainsKey(sign))
                {
                    return false;
                }
                currentTieNode = currentTieNode.Children[sign];
            }

            return currentTieNode.IsTerminated;
        }

        //Deletes the word in the trie
        public bool Remove(string word)
        {
            if (String.IsNullOrEmpty(word))
            {
                throw new WrongInputException("Wrong input");
            }

            if (!Contains(word))
            {
                return false;
            }

            --Size;

            TrieNode currentTrieNode = head.Children[word[0]];
            if (word.Length <= 1)
            {
                head.Children[word[0]].IsTerminated = false;
                return true;
            }

            for (int i = 1; i < word.Length; ++i)
            {
                currentTrieNode.WordsWithSuchPrefix--;
                if (currentTrieNode.Children[word[i]].WordsWithSuchPrefix == 1)
                {
                    currentTrieNode.Children[word[i]].IsTerminated = false;
                    return true;
                }
                currentTrieNode = currentTrieNode.Children[word[i]];

            }
            currentTrieNode.IsTerminated = false;
            return true;
        }

        // Finds amount of words staring with the prefix
        public int HowManyStartsWithPrefix(string prefix)
        {
            if (String.IsNullOrEmpty(prefix))
            {
                throw new WrongInputException("Wrong input");
            }

            TrieNode currentTrieNode = head;
            foreach (char sign in prefix)
            {
                if (currentTrieNode.Children.ContainsKey(sign))
                {
                    currentTrieNode = currentTrieNode.Children[sign];
                }
                else
                {
                    return 0;
                }
            }
            return currentTrieNode.WordsWithSuchPrefix;
        }
    }
}
