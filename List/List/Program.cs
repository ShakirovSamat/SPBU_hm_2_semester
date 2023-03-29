using List.Exceptions;

namespace List
{
    public class Program
    {
        private static int GetNumber(string message, out int number)
        {
            while (true)
            {
                Console.Write(message);
                bool isNumber = int.TryParse(Console.ReadLine(), out number);
                if (isNumber)
                {
                    break;
                }
                Console.WriteLine("Wrong input");
            }
            return number;
        }

        public static void Main()
        {
            Console.WriteLine("*****This programm shows how unique list works*****\n");
            Console.WriteLine("Commands:\n1 - add new element to the unique list\n" +
                                        "2 - reset exsisitng element in the unique list\n" +
                                        "3 - delete element from the unique list\n" +
                                        "4 - print the unique list\n" +
                                        "0 - exit from the program\n");
            int command = -1;
            UniqueList uniqueList = new UniqueList();
            bool processing = true;

            while (processing)
            {
                while (true)
                {
                    Console.Write("Enter command: ");
                    bool isNumber = int.TryParse(Console.ReadLine(), out command);
                    if (isNumber && 0 <= command && command <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Wrong command");
                }
                int number = 0;
                switch (command)
                {
                    case 0:
                        processing = false;
                        break;

                    case 1:
                        GetNumber("Enter number that should be added: ", out number);
                        try
                        {
                            uniqueList.Add(number);
                        }
                        catch (AddSameValueException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 2:
                        GetNumber("Enter number that should be deleted: ", out number);
                        try
                        {
                            uniqueList.Delete(number);
                        }
                        catch (DeleteNotExistingElementException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 3:
                        int index = 0;
                        GetNumber("Enter index: ", out index);
                        GetNumber("Enter new number: ", out number);
                        try
                        {
                            uniqueList.Reset(index, number);
                        }
                        catch (ResetingToAldreadyExisingElementException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        catch (IndexOutOfRangeException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 4:
                        uniqueList.print();
                        break;
                }

            }

        }
    }


}