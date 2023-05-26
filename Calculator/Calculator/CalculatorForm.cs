namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        CalculatorLogic.CalculatorLogic calculator = new();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void AdditionButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            double.TryParse(input[input.Length - 1], out double number);
            try
            {
                calculator.Calculate(number, '+');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void SubtractionButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            if (input[input.Length - 1] == "")
            {
                inOutLabel.Text += "-";
                return;
            }

            double.TryParse(input[input.Length - 1], out double number);
            try
            {
                calculator.Calculate(number, '-');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void MultiplicationButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            double.TryParse(input[input.Length - 1], out double number);
            try
            {
                calculator.Calculate(number, '*');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void DivisionButtonMouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            double.TryParse(input[input.Length - 1], out double number);
            try
            {
                calculator.Calculate(number, '/');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void equalsButton_MouseClick(object sender, MouseEventArgs e)
        {
            string[] input = inOutLabel.Text.Split(' ');
            double.TryParse(input[input.Length - 1], out double number);
            try
            {
                calculator.Calculate(number, '=');
            }
            catch (DivideByZeroException exception)
            {
                inOutLabel.Text = exception.Message;
            }
            inOutLabel.Text = calculator.CurrentOutput;
        }

        private void HandleNumberButton(string text)
        {
            char[] input = inOutLabel.Text.ToCharArray();
            Array.Reverse(input);
            if (input.Length == 0 || input[0] != '0')
            {
                inOutLabel.Text += text;
            }
        }

        private void OneButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void TwoButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void ThreeButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void FourButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void FiveButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void SixButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void SevenButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void EightButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void NineButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }

        private void ZeroButtonMouseClick(object sender, MouseEventArgs e)
        {
            Button button = (Button)sender;
            HandleNumberButton(button.Text);
        }
    }
}