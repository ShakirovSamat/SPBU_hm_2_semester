using Trees.Trie;

class Program
{

    static int Test()
    {
        Trie trie = new Trie();
        trie.Add("Car");
        trie.Add("Cat");
        if (trie.GetSize() != 2)
        {
            return 1;
        }

        if (!trie.Contains("Car") || trie.Contains("Ca") || trie.Contains("Cart") || !trie.Contains("Car"))
        {
            return 2;
        }

        trie.Add("Carry");
        trie.Remove("Car");
        if (trie.Contains("Car"))
        {
            return 3;
        }

        trie.Add("Car");
        if (trie.HowManyStartsWithPrefix("Ca") != 3)
        {
            return 4;
        }
        return 0;
    }
    static void Main()
    {
        int errorCode = Test();
        if (errorCode != 0)
        {
            Console.WriteLine($"Error code: {errorCode}");
        }
        Trie trie = new Trie();
        string? command;
        bool processing = true;
        Console.WriteLine("Trie program\n");
        Console.WriteLine("Commands:" +
            "\n1 - Add new string" +
            "\n2 - Remove string" +
            "\n3 - get size" +
            "\n4 - how many words starts with prefix" +
            "\n5 - Is word in trie\n6 - close the program\n");

        while(processing)
        {
            Console.Write("Enter command: ");
            command = Console.ReadLine();
            string? word;
            switch (command)
            {
                case "1":
                    Console.Write("Enter word: ");
                    word = Console.ReadLine();
                    trie.Add(word);
                    break;

                case "2":
                    Console.Write("Enter word: ");
                    word = Console.ReadLine();
                    trie.Remove(word);
                    break;

                case "3":
                    Console.WriteLine($"Size is {trie.GetSize()}");
                    break;

                case "4":
                    Console.Write("Enter prefix: ");
                    word = Console.ReadLine();
                    Console.WriteLine($"{trie.HowManyStartsWithPrefix(word)} words starts with {word}");
                    break;

                case "5":
                    Console.Write("Wnter word: ");
                    word = Console.ReadLine();
                    if (trie.Contains(word))
                    {
                        Console.WriteLine($"{word} is in trie");
                    }
                    else
                    {
                        Console.WriteLine($"{word} is NOT in trie");
                    }
                    break;

                case "6":
                    processing = false;
                    break;

                default:
                    Console.WriteLine("Worng input");
                    break;
            }
            Console.WriteLine();
        }
    }
      
}
