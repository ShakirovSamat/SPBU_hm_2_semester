namespace Generics
{
    public class Program
    {
        public static void Main()
        {
            SkipList<string> skipList = new SkipList<string>();
           
            Console.WriteLine("*****Skip List demonstration*****");

            Console.WriteLine("Commnads:\n" +
                "1 - Add new element to the skip list\n" +
                "2 - Find element in the skip list\n" +
                "3 - Delete element from the skip list by value\n" +
                "4 - Delete element from the skip list by index\n" +
                "5 - Get index of element by value\n" +
                "6 - Clear the skip list");

            bool processing = true;
            int commnad = 0;
            while (processing)
            {
                while (true)
                {
                    Console.Write("\nEnter commnad: ");
                    if (int.TryParse(Console.ReadLine(), out commnad))
                    {
                        break;
                    }
                }
                String value;
                switch (commnad)
                {
                    case 1:
                        Console.Write("Enter value: ");
                        value = Console.ReadLine();
                        skipList.Add(value);
                        break;
                    case 2:
                        Console.Write("Enter value: ");
                        value = Console.ReadLine();
                        if (skipList.Contains(value))
                        {
                            Console.WriteLine($"{value} contains in the skip list");
                        }
                        else
                        {
                            Console.WriteLine($"{value} doesn't contain in the skip list");
                        }
                        break;
                    case 3:
                        Console.Write("Enter value: ");
                        value = Console.ReadLine();
                        skipList.Remove(value);
                        break;
                    case 4:
                        Console.Write("Enter index: ");
                        if (int.TryParse(Console.ReadLine(), out int index))
                        {
                            skipList.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Wrong index");
                        }
                        break;
                    case 5:
                        Console.Write("Enter value: ");
                        value = Console.ReadLine();
                        Console.WriteLine($"Index of element is {skipList.IndexOf(value)}");
                        break;
                    case 6:
                        skipList.Clear();
                        break;
                    default:
                        Console.WriteLine("Wrong command");
                        break;
                }

            }
        }
    }
}