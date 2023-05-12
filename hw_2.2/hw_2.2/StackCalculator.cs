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
                throw new ArgumentException("Bad input");
            }
        }

        private (double, double) GetNumbers()
        {
            (bool isNumber, double number) firstPopResult = stack.Pop();
            CheckNumber(firstPopResult.isNumber);

            (bool isNumber, double number) secondPopResult = stack.Pop();
            CheckNumber(secondPopResult.isNumber);

            return (firstPopResult.number, secondPopResult.number);
        }

        public double Calculate(string str)
        {
            string[] input = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; ++i)
            {
                if (input[i] == "+")
                {
                    (double x, double y) numbers = GetNumbers();

                    stack.Push(numbers.x + numbers.y);
                }
                else if (input[i] == "-")
                {
                    (double x, double y) numbers = GetNumbers();

                    stack.Push(numbers.y - numbers.x);
                }
                else if (input[i] == "*")
                {
                    (double x, double y) numbers = GetNumbers();

                    stack.Push(numbers.x * numbers.y);
                }
                else if (input[i] == "/")
                {
                    (double x, double y) numbers = GetNumbers();
                    if (numbers.x.CompareTo(0) == 0)
                    {
                        Console.WriteLine("Dividing by zero exception");
                        Environment.Exit(0);
                    }

                    stack.Push(numbers.y / numbers.x);
                }
                else
                {
                    bool isNumber = int.TryParse(input[i], out int number);
                    CheckNumber(isNumber);
                    stack.Push(number);
                }
            }
            (bool isNumber, double number) popRsult= stack.Pop();
            if (!stack.isEmpty)
            {
                throw new ArgumentException("Bad input");
            }
            return popRsult.number;
        }
    }
}
