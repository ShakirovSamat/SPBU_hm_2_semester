using System.Data;

namespace LZW
{
    class Program
    {
        static void Main()
        {
            // Качественно реализовать структуру данных бор
            // Реализовать класс архиватора и разоархиватора
            string? pathAndKey;
          
            while (true)
            {


                Console.WriteLine("<<<<<This program compresses and decompresses files by LZW algorithm>>>>>\n");
                Console.Write("Please, enter the absolute path to the file and key:\n-c - to compress the file\n" +
                    "-u - to decompress the file\nFormat - Path key: ");
                pathAndKey = Console.ReadLine();

                if (pathAndKey != null && pathAndKey.Split(' ').Length == 2 && (pathAndKey.Split(' ')[1] == "-c" || pathAndKey.Split(' ')[1] == "-u"))
                {
                    if (File.Exists(@pathAndKey.Split(' ')[0]))
                    {
                        break;
                    }
                    Console.WriteLine("Bad path");
                }
                else
                {
                    Console.WriteLine("Bad key");
                }
            }

            string path = pathAndKey.Split(' ')[0];
            string key = pathAndKey.Split(' ')[1];
            string? fileText;

            using (StreamReader stream = new StreamReader(path, true))
            {
                fileText = stream.ReadToEnd();
            }

            FileInfo fi = new FileInfo(@path);
            string[] str = path.Split('\\');
            path = string.Empty;
            for (int i = 0; i < str.Length - 1; ++i)
            {
                path += str[i] + @"\";
            }

            if (key == "-c")
            {
                path = path + fi.Name.Split('.')[0] + ".zipped.txt";
                string compressed = LZW.Compress(fileText);

                File.Create(@path).Close();
                using (StreamWriter stream = new StreamWriter(@path))
                {
                    stream.Write(string.Join(" ", compressed));
                }
            }
            else if (key == "-u")
            {
                str = fileText.Split(' ');
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

