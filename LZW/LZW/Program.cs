using System.Data;

namespace LZW
{
    class Program
    {
        static void Main(String[] args)
        {                   
            FileInfo file = new FileInfo(args[0]);
            string[] str = args[0].Split('\\');
            string path = string.Empty;
            for (int i = 0; i < str.Length - 1; ++i)
            {
                path += str[i] + @"\";
            }

            if (args[1] == "-c")
            {
                path = path + file.Name.Split('.')[0] + ".zipped";
                string compressed = LZW.Compress(File.ReadAllBytes(args[0]));

                File.Create(@path).Close();
                using (StreamWriter stream = new StreamWriter(@path))
                {
                    stream.Write(string.Join(" ", compressed));
                }
            }
            else if (args[1] == "-u")
            {
                int[] compressed = new int[str.Length];
                for (int i = 0; i < str.Length; ++i)
                {
                    compressed[i] = int.Parse(str[i]);
                }

                path = path + fi.Name.Split('.')[0] + ".txt";
                string decompressed = LZW.Decompress(compressed);

                File.Create(@path).Close();
                using (StreamWriter stream = new StreamWriter(@path))
                {
                    stream.Write(decompressed.ToString());
                }
            }


        }
    }

}

