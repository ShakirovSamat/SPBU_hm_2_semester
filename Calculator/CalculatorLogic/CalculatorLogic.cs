namespace CalculatorLogic
{
    public class Calculator
    {
        double firstNumber;
        double secondNumber;
        public string CurrentOutput { get; set; }
        char currentOperation;
        string currentState = "WaitingForFirstNumber";
        public void Calculate(double number, char operation)
        {
            switch (currentState)
            {
                case "WaitingForFirstNumber":
                    {
                        firstNumber = number;
                        CurrentOutput = firstNumber.ToString() + " " + operation + " ";
                        currentOperation = operation;
                        currentState = "WaitingForSecondNumber";
                        break;
                    }
                case "WaitingForSecondNumber":
                    {
                        secondNumber = number;
                        switch (currentOperation)
                        {
                            case '+':
                                {
                                    firstNumber = firstNumber + secondNumber;
                                    break;
                                }
                            case '-':
                                {
                                    firstNumber = firstNumber - secondNumber;
                                    break;
                                }
                            case '*':
                                {
                                    firstNumber = secondNumber * firstNumber;
                                    break;
                                }
                            case '/':
                                {
                                    if (Math.Abs(secondNumber) < Double.Epsilon)
                                    {
                                        throw new DivideByZeroException();
                                    }
                                    firstNumber = firstNumber / secondNumber;
                                    break;
                                }
                        }
                        currentOperation = operation;
                        if (currentOperation == '=')
                        {
                            currentState = "WaitingForFirstNumber";
                            CurrentOutput = "= " + firstNumber.ToString();
                        }
                        else
                        {
                            CurrentOutput = firstNumber.ToString() + " " + currentOperation + " ";
                        }
                        break;
                    }
            }
        }
    }
}
