namespace program
{
    // stacl calculator realization
    public class StackCalculator
    {
        IStack stack;
        public StackCalculator(IStack stack)
        {
            this.stack = stack;
        }


        private bool CheckNumber(bool isNumber)
        {
            if (!isNumber)
            {
                Console.WriteLine("Wrong input. Input must contain numbers or +, -, *, /. Between symbols must be space.\n" +
                    "if symbols are correct then arithmetic expression is wrong");
                return false;
            }
            return true;
        }

        private (double, double, bool) GetNumbers()
        {
            bool isNumber = stack.Pop(out double firstNumber);
            bool first = CheckNumber(isNumber);

            isNumber = stack.Pop(out double secondNumber);
            bool second = CheckNumber(isNumber);

            return (firstNumber, secondNumber, first && second);
        }

        public double Calculate(string str)
        {
            string[] input = str.Split(' ');
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == "+")
                {
                    (double, double, bool) numbers = GetNumbers();
                    if (!numbers.Item3)
                    {
                        return 0.0 / 0.0;
                    }

                    stack.Push(numbers.Item1 + numbers.Item2);
                }
                else if (input[i] == "-")
                {
                    (double, double, bool) numbers = GetNumbers();
                    if (!numbers.Item3)
                    {
                        return 0.0 / 0.0;
                    }

                    stack.Push(numbers.Item2 - numbers.Item1);
                }
                else if (input[i] == "*")
                {
                    (double, double, bool) numbers = GetNumbers();
                    if (!numbers.Item3)
                    {
                        return 0.0 / 0.0;
                    }

                    stack.Push(numbers.Item1 * numbers.Item2);
                }
                else if (input[i] == "/")
                {
                    (double, double, bool) numbers = GetNumbers();
                    if (!numbers.Item3)
                    {
                        return 0.0 / 0.0;
                    }

                    if (numbers.Item1.CompareTo(0) == 0)
                    {
                        Console.WriteLine("Dividing by zero exception");
                        return 0.0 / 0.0;
                    }

                    stack.Push(numbers.Item2 / numbers.Item1);
                }
                else
                {
                    bool isNumber = int.TryParse(input[i], out int number);
                    if (!CheckNumber(isNumber))
                    {
                        return 0.0 / 0.0;
                    }
                    stack.Push(number);
                }
            }
            stack.Pop(out double result);
            if (!stack.isEmpty())
            {
                Console.WriteLine("Wrong input. Input must contain numbers or +, -, *, /. Between symbols must be space.\n" +
                    "if symbols are correct then arithmetic expression is wrong");
                Environment.Exit(0);
            }
            return result;
        }
    }
}
