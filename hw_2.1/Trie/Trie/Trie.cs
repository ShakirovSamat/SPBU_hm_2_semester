namespace Trees.Trie
{
    // Trie data structure realization
    public class Trie
    {
        private TrieNode head;
        private int size;

        private class TrieNode
        {
            public char value;
            public int branches;
            public bool isTerminated;
            public Dictionary<char, TrieNode> children;

            public TrieNode(char value)
            {
                this.value = value;
                children = new Dictionary<char, TrieNode>();
                branches = 1;
            }
            public TrieNode()
            {
                children = new Dictionary<char, TrieNode>();
                branches = 1;
            }
        }
        public Trie()
        {
            head = new TrieNode();
        }

        //Adds new word to the trie
        public bool Add(string word)
        {
            if (word == null || word == "")
            {
                Console.WriteLine("Wrong input");
                return false;
            }

            if (Contains(word))
            {
                return false;
            }

            TrieNode currentTrieNode = head;
            foreach(char sign in word)
            {
                if (currentTrieNode.children.ContainsKey(sign))
                {
                    currentTrieNode = currentTrieNode.children[sign];
                    currentTrieNode.branches++;
                }
                else
                {
                    currentTrieNode.children.Add(sign, new TrieNode(sign));
                    currentTrieNode = currentTrieNode.children[sign];
                }
            }

            currentTrieNode.isTerminated = true;
            ++size;
            return true;
        }

        //Searchs the word in the trie
        public bool Contains(string word)
        {
            if (word == null || word == "")
            {
                Console.WriteLine("Wrong input");
                return false;
            }
            TrieNode currentTieNode = head;
            foreach(char sign in word)
            {
                if (!currentTieNode.children.ContainsKey(sign))
                {
                    return false;
                }
                currentTieNode = currentTieNode.children[sign];
            }
                   
            return currentTieNode.isTerminated;
        }

        //Deletes the word in the trie
        public bool Remove(string word)
        {
            if (word == null || word == "")
            {
                Console.WriteLine("Wrong input");
                return false;
            }

            if (!Contains(word))
            {
                return false;
            }

            --size;

            TrieNode currentTrieNode = head.children[word[0]];
            for (int i= 1; i < word.Length; ++i)
            {
                currentTrieNode.branches--;
                if (currentTrieNode.children[word[i]].branches == 1)
                {
                    currentTrieNode.children.Remove(word[i]);
                    return true;
                }
                currentTrieNode = currentTrieNode.children[word[i]];
                
            }
            return true;
        }

        // Finds amount of words staring with the prefix
        public int HowManyStartsWithPrefix(string prefix)
        {
            if (prefix == null || prefix == "")
            {
                Console.WriteLine("Wrong input");
                return 0;
            }

            TrieNode currentTrieNode = head;
            foreach(char sign in prefix)
            {
                if (currentTrieNode.children.ContainsKey(sign))
                {
                    currentTrieNode = currentTrieNode.children[sign];
                }
                else
                {
                    return 0;
                }
            }
            return currentTrieNode.branches;
        }

        // returns amount of words in the trie
        public int GetSize()
        {
            return size;
        }

    }
}
