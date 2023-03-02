using System;
using System.Text;

namespace hm_1._2
{
    class Program
    {
        //calculate BWT
        static string GetBWT(string str)
        {
            byte[] strInASCII = Encoding.ASCII.GetBytes(str);
            int[,] circlePermutations = new int[strInASCII.Length, strInASCII.Length];

            string result = "";
            int numberOfoOriginalString = 1;
            bool isOriginalStringSorted = false;

            //Creat all circle permutations
            for (int i = 0; i < strInASCII.Length; ++i)
            {
                for (int j = 0; j < strInASCII.Length; ++j)
                {
                    circlePermutations[i, j] = strInASCII[(i + j) % strInASCII.Length];
                }
            }
            // step by step find the smallest permutation and write last char in result
            for (int i = 0; i < strInASCII.Length; ++i)
            {

                int min = 0;
                for (int j = 0; j < strInASCII.Length; ++j)
                {
                    int depth = 0;
                    while (depth < strInASCII.Length && circlePermutations[min, depth] == circlePermutations[j, depth])
                    {
                        ++depth;
                    }
                    if (depth < strInASCII.Length && circlePermutations[min, depth] > circlePermutations[j, depth])
                    {
                        min = j;
                    }

                }
                // next two conditions are needed to find number of original permutation
                if (min == 0)
                {
                    isOriginalStringSorted = true;
                }

                if (!isOriginalStringSorted)
                {
                    ++numberOfoOriginalString;
                }
                result += (char)circlePermutations[min, strInASCII.Length - 1];
                circlePermutations[min, 0] = 1000;
            }


            return result + " " + Convert.ToString(numberOfoOriginalString);
        }

        static string ReverseBTW(string str, int numberOfOriginString)
        {
            --numberOfOriginString;

            // form alphabet
            string alphabet = "";
            for (int i = 0; i < 127; ++i)
            {
                if (str.Contains((char)i))
                {
                    alphabet += Convert.ToString((char)i);
                }
            }

            // amount of every sign
            int[] count = new int[alphabet.Length];
            for (int i = 0; i < count.Length; ++i)
            {
                for (int j = 0; j < str.Length; ++j)
                {
                    if (str[j] == alphabet[i])
                    {
                        ++count[i];
                    }
                }
            }

            int[] sum = new int[count.Length];
            sum[0] = 1;
            for (int i = 1; i < sum.Length; ++i)
            {
                sum[i] = count[i - 1] + sum[i - 1];
            }

            // form auxiliary array
            int[] p = new int[str.Length];
            for (int i = 0; i < str.Length; ++i)
            {
                int index = 0;
                while (str[i] != alphabet[index])
                {
                    ++index;
                }
                p[i] = sum[index];
                ++sum[index];
            }


            // reverse BTW string
            string result = "";

            int currentIndex = numberOfOriginString;
            int previousIndex = -1;

            result += str[numberOfOriginString];
            for (int i = 0; i < str.Length - 1; ++i)
            {
                previousIndex = currentIndex;
                currentIndex = p[previousIndex] - 1;
                result += str[currentIndex];
            }


            char[] array = result.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
        static void Main(string[] args)
        {
            int command = 0;
            Console.WriteLine("If you want to make a BWT string from an ordinary string, enter - 1");
            Console.Write("If you want to make an ordinary string from a BWT string, enter - 2\nEnter command: ");


            //input
            while (command != 1 && command != 2)
            {
                bool isNumber = int.TryParse(Console.ReadLine(), out command);
                if (!isNumber || (command != 1 && command != 2))
                {
                    Console.WriteLine("Wrong input");
                }
            }

            if (command == 1)
            {
                Console.Write("Enter string: ");
                string str = Console.ReadLine();
                string btwString = GetBWT(str);
                Console.WriteLine($"{btwString}");
            }
            else
            {
                bool isNumber = false;
                int numberOfOriginString = 0;
                string str = "";

                // input
                while (!isNumber)
                {
                    Console.Write("Enter string: ");
                    str = Console.ReadLine();
                    //get number of origin string
                    for (int i = str.Length - 1; i >= 0; --i)
                    {
                        if (str[i] == ' ')
                        {
                            string num = "";
                            for (int j = i + 1; j < str.Length; ++j)
                            {
                                num += str[j];
                            }
                            isNumber = int.TryParse(num, out numberOfOriginString);
                            str = str.Replace(" " + num, "");
                            break;
                        }
                    }
                    if (!isNumber)
                    {
                        Console.WriteLine("Wrong input");
                    }
                }
                string reversedString = ReverseBTW(str, numberOfOriginString);
                if (GetBWT(reversedString) == str + " " + numberOfOriginString.ToString())
                {
                    Console.WriteLine($"Reversed string: {reversedString}");
                }
                else
                {
                    Console.WriteLine("Wrong input. The string wasn't created by BWT");
                }
                
            }
        }

    }
}
