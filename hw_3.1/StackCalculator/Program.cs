namespace program
{
    class Program
    {
        static void Main()
        {
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
