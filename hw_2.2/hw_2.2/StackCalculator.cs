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


        private void CheckNumber(bool isNumber)
        {
            if (!isNumber)
            {
                Console.WriteLine("Wrong input. Input must contain numbers or +, -, *, /. Between symbols must be space.\n" +
                    "if symbols are correct then arithmetic expression is wrong");
                Environment.Exit(0);
            }
        }

        private (double, double) GetNumbers()
        {
            bool isNumber = stack.Pop(out double firstNumber);
            CheckNumber(isNumber);

            isNumber = stack.Pop(out double secondNumber);
            CheckNumber(isNumber);

            return (firstNumber, secondNumber);
        }

        public double Calculate(string str)
        {
            string[] input = str.Split(' ');
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == "+")
                {
                    (double, double) numbers = GetNumbers();

                    stack.Push(numbers.Item1 + numbers.Item2);
                }
                else if (input[i] == "-")
                {
                    (double, double) numbers = GetNumbers();

                    stack.Push(numbers.Item2 - numbers.Item1);
                }
                else if (input[i] == "*")
                {
                    (double, double) numbers = GetNumbers();

                    stack.Push(numbers.Item1 * numbers.Item2);
                }
                else if (input[i] == "/")
                {
                    (double, double) numbers = GetNumbers();
                    if (numbers.Item1.CompareTo(0) == 0)
                    {
                        Console.WriteLine("Dividing by zero exception");
                        Environment.Exit(0);
                    }

                    stack.Push(numbers.Item2 / numbers.Item1);
                }
                else
                {
                    bool isNumber = int.TryParse(input[i], out int number);
                    CheckNumber(isNumber);
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
