using System.Text;
using System.Threading.Tasks.Dataflow;

namespace LZW
{
    public static class LZW
    {
        public static string Compress(string uncompressed)
        {
            Trie trie = new Trie();
            List<int> compressed = new List<int>();


            for (int i = 0; i < 256; ++i)
            {
                trie.Add(((char)i).ToString());
            }

            string sequence = string.Empty;
            foreach(char sign in uncompressed)
            {
                string sequencesign = sequence + sign;
                if (trie.Contains(sequencesign))
                {
                    sequence = sequencesign;
                }
                else
                {
                    compressed.Add(trie.GetNumberByWord(sequence));
                    trie.Add(sequencesign);
                    sequence = sign.ToString();
                }
            }
            
            if (!string.IsNullOrEmpty(sequence))
            {
                compressed.Add(trie.GetNumberByWord(sequence));
            }

            return string.Join(" ", compressed);
        }

        public static string Decompress(int[] compressed)
        {

            Trie trie = new Trie();
            for (int i = 0; i < 256; ++i)
            {
                trie.Add(((char)i).ToString());
            }

            string sequence = trie.GetWordByNumber(compressed[0]);
            StringBuilder decompressed = new StringBuilder(sequence);

            for (int i = 1; i < compressed.Length; ++i)
            {
                string? entry = null;
                if (trie.GetWordByNumber(compressed[i]) != string.Empty)
                {
                    entry = trie.GetWordByNumber(compressed[i]);
                }
                else if (compressed[i] == trie.GetAmountOfWords())
                {
                    entry = sequence + sequence[0];
                }

                decompressed.Append(entry);
                trie.Add(sequence + entry[0]);

                sequence = entry;
            }

            return decompressed.ToString();
        }

    }
}
