using System;
using System.Text;

namespace hm_1._2
{
    class Program
    {
        //calculate BWT
        static (string encodingString, int endPosition) GetBWT(string str)
        {
            byte[] strInASCII = Encoding.ASCII.GetBytes(str);
            var circlePermutations = new int[strInASCII.Length, strInASCII.Length];

            string result = "";
            int numberOfOriginalString = 1;
            bool isOriginalStringSorted = false;

            //Create all circle permutations
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
                    ++numberOfOriginalString;
                }
                result += (char)circlePermutations[min, strInASCII.Length - 1];
                circlePermutations[min, 0] = int.MaxValue;
            }


            return (result, numberOfOriginalString);
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
            var symbolFrequencies = new int[alphabet.Length];
            for (int i = 0; i < symbolFrequencies.Length; ++i)
            {
                for (int j = 0; j < str.Length; ++j)
                {
                    if (str[j] == alphabet[i])
                    {
                        ++symbolFrequencies[i];
                    }
                }
            }

            var sum = new int[symbolFrequencies.Length];
            sum[0] = 1;
            for (int i = 1; i < sum.Length; ++i)
            {
                sum[i] = symbolFrequencies[i - 1] + sum[i - 1];
            }

            // form auxiliary array
            var p = new int[str.Length];
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
                var btwResult = GetBWT(str);
                Console.WriteLine($"{btwResult.encodingString}, {btwResult.endPosition}");
            }
            else
            {
                // input
                Console.Write("Enter string btw: ");
                string btwString = Console.ReadLine();
                int btwNumber = 0;
                while (true)
                {
                    Console.Write("Enter btw number: ");
                    if(int.TryParse(Console.ReadLine(), out btwNumber))
                    {
                        break;
                    }
                }
                
                string reversedString = ReverseBTW(btwString, btwNumber);
                var btwResult = GetBWT(reversedString);
                if (btwResult.encodingString == btwString && btwResult.endPosition == btwNumber)
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
