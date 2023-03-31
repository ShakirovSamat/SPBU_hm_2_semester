using ArithmeticTree.Exceptions;
using System.Net.Http.Headers;

namespace ArithmeticTree
{
    public class Program
    {
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
                Tree tree = new Tree(input);
                Console.WriteLine($"Tree: {tree.ToString()}");
                Console.WriteLine($"Result: {tree.Calculate()}");
            }
            catch (BadArithmeticExpressionException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
