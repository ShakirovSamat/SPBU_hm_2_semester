using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace LZW
{
    public static class LZW
    {
        const int LENGTH = 256;
        public static string Compress(byte[] uncompressed)
        {
            Trie trie = new Trie();
            List<byte> compressed = new List<byte>();


            for (byte i = 0; i < LENGTH; ++i)
            {
                trie.Add(i);
            }

            string sequence = string.Empty;
            foreach(byte sign in uncompressed)
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
            if (compressed == null)
            {
                return String.Empty;
            }

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
