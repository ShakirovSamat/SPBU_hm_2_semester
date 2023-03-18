using System.Net.Http.Headers;

namespace program
{
    class Program
    {
        static bool Test()
        {
            string[] inputs = new string[]
            {
                "99 99 +",
                "1 0 +",
                "-1 1 +",
                "5 5 -",
                "10 99 -",
                "5 7 *",
                "5 0 *",
                "-5 65 *",
                "-5 -9 *",
                "5 5 /",
                "1 5 /",
                "-99 -9 /",
                "216 -6 /",
                "2 2 3 + *"
            };
            double[] answers = new double[]
            {
                198,
                1,
                0,
                0,
                -89,
                35,
                0,
                -325,
                45,
                1,
                0.2,
                11,
                -36,
                10
                };
            StackCalculator stackCalculatorBasedOnArray = new StackCalculator(new StackBasedOnArray());
            StackCalculator stackCalculatorBasedOnLinkedList = new StackCalculator(new StackBasedOnLinkedList());
            for (int i = 0; i < inputs.Length; ++i)
            {
                if (stackCalculatorBasedOnArray.Calculate(inputs[i]) != answers[i])
                {
                    return false;
                }
                if (stackCalculatorBasedOnLinkedList.Calculate(inputs[i]) != answers[i])
                {
                    return false;
                }
            }
            return true;

        }
        static void Main()
        {
            if (!Test())
            {
                Console.WriteLine("Test failed");
                Environment.Exit(0);
            }

            Console.WriteLine("This is the stack calculator\n\nChoose the stack that will be used:\n1 - A stack based on an array\n" +
                "2 - A stack based on a linked list");
            int command = 0;

            while (!(command == 1 || command == 2))
            {
                Console.Write("Enter command: ");
                if(!int.TryParse(Console.ReadLine(), out command) || command != 2 && command != 1)
                {
                    Console.WriteLine("Wrong input!");
                }

            }

            StackCalculator stackCalculator;
            switch (command)
            {
                case 1:
                    stackCalculator = new StackCalculator(new StackBasedOnArray());
                    Console.WriteLine("A stack based on an array was choosen\n");
                    break;
                case 2:
                    stackCalculator = new StackCalculator(new StackBasedOnLinkedList());
                    Console.WriteLine("A stack based on a linked list was choosen\n");
                    break;
                default:
                    stackCalculator = new StackCalculator(new StackBasedOnLinkedList());
                    Console.WriteLine("A stack based on a linked list was choosen\n");
                    break;

            }

            Console.Write("Enter arithmetic expression as a string in postfix notation\nExpression: ");
            string? input;

            while (true)
            {
                input = Console.ReadLine();
                if (input != null)
                {
                    break;
                }
            }
            
            Console.WriteLine($"\n\nResult: {stackCalculator.Calculate(input)}");
        }
    }
}
