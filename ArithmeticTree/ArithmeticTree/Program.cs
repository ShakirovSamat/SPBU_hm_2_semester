using ArithmeticTree.Exceptions;
using System.Net.Http.Headers;

namespace ArithmeticTree
{
    public class Program
    {
        /// <summary>
        /// gets path to tje file with arithmetic expression and calculates it
        /// </summary>
        public static void Main()
        {
            Console.WriteLine("*****Arithmetic expression parse tree*****\n");
            Console.Write("Enter absolute path to file: ");
            string path = String.Empty;
            string input = String.Empty;

            while (true)
            {
                Console.Write("Enter absolute path to file: ");
                path = Console.ReadLine();
                if (File.Exists(@path))
                {
                    using (StreamReader stream = new StreamReader(@path, true))
                    {
                        input = stream.ReadToEnd();
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Wrong path. File with such path doesn't exist");
                }
            }
            try
            {
                var tree = new Tree(input);
                Console.WriteLine($"Tree: {tree.ToString()}");
                Console.WriteLine($"Result: {tree.Calculate()}");
            }
            catch (Exception e)
                when (e is BadArithmeticExpressionException || e is DivideByZeroException)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
